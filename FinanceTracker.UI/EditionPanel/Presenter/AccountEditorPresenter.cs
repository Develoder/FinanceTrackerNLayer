using FinanceTracker.DAL;
using FinanceTracker.UI.EditionPanel.View.Interface;
using FinanceTracker.Domain.Service;
using FinanceTracker.Domain.Validator;

namespace FinanceTracker.UI.EditionPanel.View.Presenter
{
    public class AccountEditorPresenter
    {
        private IAccountEditorView _accountEditorView;
        private AccountService _accountService;
        private Account _account;

        private List<TypeAccount> _typeAccounts;

        public event EventHandler Cancel;
        public event EventHandler Apply;

        public AccountEditorPresenter(IAccountEditorView accountEditorView, AccountService accountService)
        {
            _accountEditorView = accountEditorView;
            _accountService = accountService;

            _accountEditorView.Apply += AccountEditorViewApply;
            _accountEditorView.Cancel += AccountEditorViewCancel;

            Initialize();
        }

        private void Initialize()
        {
            _typeAccounts = _accountService.GetTypeAccounts();
            string[] nameTupeAccount = _typeAccounts
                .OrderBy(x => x.Order)
                .Select(x => x.Name.Trim())
                .ToArray();
            _accountEditorView.SetAllTypeAccount(nameTupeAccount);
            _accountEditorView.IndexTypeAccount = 0;

            _accountEditorView.ClearWarning();
        }

        public void EditAccount(int accountId)
        {
            _account = _accountService.GetAccount(accountId);
            _accountEditorView.AccountName = _account.Name.Trim();
            TypeAccount typeAccount = _typeAccounts.First(x => x.Id == _account.TypeId);
            _accountEditorView.IndexTypeAccount = _typeAccounts.IndexOf(typeAccount);
        }

        public void CreateAccount()
        {
            _account = null;
            _accountEditorView.CreateAccount();
        }

        private void AccountEditorViewApply(object? sender, EventArgs e)
        {
            Account simpleAccount = GetSipleAccountFromView();
            AccountValidator accountValidation = new(simpleAccount);
            accountValidation.Validate();

            if (accountValidation.IsWarning)
            {
                _accountEditorView.ShowWarning(accountValidation.TextWarning);
                return;
            }

            try
            {
                Save(simpleAccount);
            }
            catch
            {
                _accountEditorView.ShowWarning("Критическая ошибка сохранения данных");
                return;
            }

            _accountEditorView.ClearWarning();
            Apply.Invoke(this, EventArgs.Empty);
        }

        private Account GetSipleAccountFromView()
        {
            int typeIndex = _accountEditorView.IndexTypeAccount;
            int typeId = _typeAccounts[typeIndex].Id;
            string accountName = _accountEditorView.AccountName.Trim();

            Account simpleAccount = new() { Name = accountName, TypeId = typeId };
            return simpleAccount;
        }

        private void Save(Account simpleAccount)
        {
            if (IsCreateMode())
                CreateNewAccount(simpleAccount);
            else
                UpdateAccount(simpleAccount);
        }

        private bool IsCreateMode()
        {
            return _account == null;
        }

        private void CreateNewAccount(Account simpleAccount)
        {
            Account account = new() { Name = simpleAccount.Name, Balance = 0, TypeId = simpleAccount.TypeId, UserId = Session.CurrentUser.Id };
            _accountService.AddAccount(account);
        }

        private void UpdateAccount(Account simpleAccount)
        {
            _account.TypeId = simpleAccount.TypeId;
            _account.Name = simpleAccount.Name;
            _accountService.UpdateAccount(_account);
        }

        private void AccountEditorViewCancel(object? sender, EventArgs e)
        {
            Cancel.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            _accountService.Dispose();
        }
    }
}
