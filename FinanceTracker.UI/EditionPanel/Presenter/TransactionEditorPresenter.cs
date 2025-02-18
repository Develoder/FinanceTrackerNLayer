using FinanceTracker.DAL;
using FinanceTracker.UI.EditionPanel.Interface;
using FinanceTracker.Domain.Service;
using FinanceTracker.Domain.Validator;

namespace FinanceTracker.UI.EditionPanel.Presenter
{
    public class TransactionEditorPresenter
    {
        private TransactionService _transactionService;
        private ITransactionEditorView _transactionEditorView;

        private Transaction _editableTransaction;

        private bool _isIncome;
        private List<CategoryTransaction> _categoryTransactions;
        private List<Account> _accounts;

        public event EventHandler Cancel;
        public event EventHandler Apply;

        public TransactionEditorPresenter(TransactionService transactionService, ITransactionEditorView transactionEditorView)
        {
            _transactionService = transactionService;
            _transactionEditorView = transactionEditorView;

            _transactionEditorView.Apply += TransactionEditorViewApply;
            _transactionEditorView.Cancel += TransactionEditorViewCancel;
            _transactionEditorView.ChangeTypeTransaction += ChangeTypeTransaction;

            Initialize();
        }

        private void Initialize()
        {
            LoadAccounts();
            _transactionEditorView.ClearWarning();
        }

        private void LoadAccounts()
        {
            _accounts = _transactionService.GetAccountsByUserId(Session.CurrentUser.Id);
        }

        public void EditTransaction(int transactionId)
        {
            _editableTransaction = _transactionService.GetTransaction(transactionId);
            CategoryTransaction editableCategoryTransaction = _transactionService.GetCategoryTransaction(_editableTransaction.CategoryId);
            _isIncome = editableCategoryTransaction.IsIncome;

            LoadData();
            FillView();
        }

        public void CreateTransaction()
        {
            _editableTransaction = null;
            _isIncome = true;

            LoadData();
            FillView();
        }

        private void ChangeTypeTransaction(object? sender, EventArgs e)
        {
            _isIncome = !_isIncome;
            LoadData();
            FillView();
        }

        private void LoadData()
        {
            if (_isIncome)
                LoadIncomeCategoryTransactions();
            else
                LoadExpenseCategoryTransactions();
        }

        private void LoadIncomeCategoryTransactions()
        {
            _categoryTransactions = _transactionService.GetIncomeCategoryTransactions();
        }

        private void LoadExpenseCategoryTransactions()
        {
            _categoryTransactions = _transactionService.GetExpenseCategoryTransactions();
        }

        private void FillView()
        {
            if (_editableTransaction == null)
                FillViewCretable();
            else
                FillViewEditable();
        }

        private void FillViewCretable()
        {
            ChangeOperation();
            _transactionEditorView.Amount = 0;

            string[] categoryTransactionNames = GetCategoryTransactionNames();
            _transactionEditorView.SetCategoryTransactions(categoryTransactionNames);
            _transactionEditorView.CategoryTransactionIndex = 0;

            string[] accountNames = GetAccountNames();
            _transactionEditorView.SetAccountNames(accountNames);
            _transactionEditorView.AccountIndex = 0;

            _transactionEditorView.DateTime = DateTime.Now;
            _transactionEditorView.Description = string.Empty;
        }

        private void FillViewEditable()
        {
            ChangeOperation();
            _transactionEditorView.Amount = Math.Round(_editableTransaction.Amount, 2);

            string[] categoryTransactionNames = GetCategoryTransactionNames();
            _transactionEditorView.SetCategoryTransactions(categoryTransactionNames);
            int categoryTransactionIndex = FindIndexCategoryTransaction();
            _transactionEditorView.CategoryTransactionIndex = categoryTransactionIndex;

            string[] accountNames = GetAccountNames();
            _transactionEditorView.SetAccountNames(accountNames);
            Account account = _accounts.First(x => x.Id == _editableTransaction.AccountId);
            int accountIndex = _accounts.IndexOf(account);
            _transactionEditorView.AccountIndex = accountIndex;

            _transactionEditorView.DateTime = _editableTransaction.Date;
            _transactionEditorView.Description = _editableTransaction.Description.Trim();
        }

        private int FindIndexCategoryTransaction()
        {
            CategoryTransaction categoryTransaction = _categoryTransactions.FirstOrDefault(x => x.Id == _editableTransaction.CategoryId);
            if (categoryTransaction != null)
                return _categoryTransactions.IndexOf(categoryTransaction);
            int indexWhenChangeIsIncome = 0;
            return indexWhenChangeIsIncome;
        }

        private void ChangeOperation()
        {
            if (_isIncome)
                _transactionEditorView.SetIncomeMode();
            else
                _transactionEditorView.SetExpenseMode();
        }

        private string[] GetCategoryTransactionNames()
        {
            string[] categoryTransactionNames = _categoryTransactions
                .OrderBy(x => x.Order)
                .Select(x => x.Name.Trim())
                .ToArray();    
            return categoryTransactionNames;
        }

        private string[] GetAccountNames()
        {
            string[] accountNames = _accounts.Select(x => x.Name.ToString()).ToArray();
            return accountNames;
        }

        private void TransactionEditorViewApply(object? sender, EventArgs e)
        {
            Transaction simpleTransaction = GetSimpleTransactionFromView();
            TransactionValidator transactionValidator = new(simpleTransaction);
            transactionValidator.Validate();

            if (transactionValidator.IsWarning)
            {
                _transactionEditorView.ShowWarning(transactionValidator.TextWarning);
                return;
            }

            try
            {
                Save(simpleTransaction);
            }
            catch
            {
                _transactionEditorView.ShowWarning("Критическая ошибка сохранения данных");
                return;
            }

            _transactionEditorView.ClearWarning();
            Apply.Invoke(this, EventArgs.Empty);
        }

        private Transaction GetSimpleTransactionFromView()
        {
            decimal amount = _transactionEditorView.Amount;
            int categoryTransactionIndex = _transactionEditorView.CategoryTransactionIndex;
            int categoryTransactionId = _categoryTransactions[categoryTransactionIndex].Id;
            int accountIndex = _transactionEditorView.AccountIndex;
            int accountId = _accounts[accountIndex].Id;
            DateTime dateTime = _transactionEditorView.DateTime;
            string description = _transactionEditorView.Description.Trim();

            Transaction simpleTransaction = new()
            {
                Amount = amount,
                CategoryId = categoryTransactionId,
                AccountId = accountId,
                Date = dateTime,
                Description = description,
                UserId = Session.CurrentUser.Id
            };

            return simpleTransaction;
        }

        private void Save(Transaction simpleTransaction)
        {
            if (IsCreateMode())
                CreateNewTransaction(simpleTransaction);
            else
                UpdateTransaction(simpleTransaction);
        }

        private bool IsCreateMode()
        {
            return _editableTransaction == null;
        }

        private void CreateNewTransaction(Transaction simpleTransaction)
        {
            Transaction transaction = new()
            {
                Amount = simpleTransaction.Amount,
                CategoryId = simpleTransaction.CategoryId,
                AccountId = simpleTransaction.AccountId,
                Date = simpleTransaction.Date,
                Description = simpleTransaction.Description,
                UserId = Session.CurrentUser.Id
            };
            _transactionService.AddTransaction(transaction);
        }

        private void UpdateTransaction(Transaction simpleTransaction)
        {
            _editableTransaction.Amount = simpleTransaction.Amount;
            _editableTransaction.CategoryId = simpleTransaction.CategoryId;
            _editableTransaction.AccountId = simpleTransaction.AccountId;
            _editableTransaction.Date = simpleTransaction.Date;
            _editableTransaction.Description = simpleTransaction.Description;
            _editableTransaction.UserId = simpleTransaction.UserId;

            _transactionService.UpdateTransaction(_editableTransaction);
        }

        private void TransactionEditorViewCancel(object? sender, EventArgs e)
        {
            Cancel.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            _transactionService.Dispose();
        }
    }
}
