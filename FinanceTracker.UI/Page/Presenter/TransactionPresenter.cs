using FinanceTracker.DAL;
using FinanceTracker.UI.EditionPanel.Presenter;
using FinanceTracker.UI.EditionPanel.View;
using FinanceTracker.UI.Page.Interface;
using FinanceTracker.Domain.DTO;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.Presenter
{
    public class TransactionPresenter : IPage
    {
        private ITransactionView _transactionView;
        private TransactionViewerService _transactionViewerService;
        private TransactionService _transactionService;

        private List<TransactionViewerData> _transactionViewerData;
        private TransactionEditorPresenter _transactionEditorPresenter;

        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public TransactionPresenter(ITransactionView transactionView, TransactionViewerService transactionViewerService, TransactionService transactionService)
        {
            _transactionView = transactionView;
            _transactionViewerService = transactionViewerService;
            _transactionService = transactionService;

            _transactionView.AddTransaction += AddTransaction;
            _transactionView.DeleteTransaction += DeleteTransaction;
            _transactionView.EditTransaction += EditTransaction;

            Initialize();
        }

        private void Initialize()
        {
            _transactionViewerService.SetUserId(Session.CurrentUser.Id);
            UpdateTransactionViewerAndShow();
        }

        private void UpdateTransactionViewerAndShow()
        {
            _transactionViewerService.LoadData();

            if (_transactionViewerService.AnyTransactions())
                ShowTransactionTable();
            else
                ShowEmptyTransactionTable();
        }

        private void ShowTransactionTable()
        {
            _transactionViewerData = _transactionViewerService.GetAllAccountViewerData();
            _transactionViewerData = _transactionViewerData.OrderByDescending(x => x.DateTime).ToList();
            object[][] transactionViewerDataObjects = GenerateTransactionViewerDataObjects();
            _transactionView.ShowTransactions(transactionViewerDataObjects);
        }

        private object[][] GenerateTransactionViewerDataObjects()
        {
            object[][] transactionViewerDataObjects = new object[_transactionViewerData.Count][];
            for (int i = 0; i < _transactionViewerData.Count; i++)
            {
                TransactionViewerData transactionViewerData = _transactionViewerData[i];
                object[] transactionViewerObject = 
                [
                    GetBitmapPlusOrMinus(transactionViewerData.IsIncome), 
                    Math.Round(transactionViewerData.Amount, 2 ), 
                    transactionViewerData.TransactionCategoryName.Trim(),
                    transactionViewerData.DateTime.ToString("dd.MM.yyyy HH:mm"),
                    transactionViewerData.AccountName.Trim(),
                    transactionViewerData.Description.Trim(),
                ];
                transactionViewerDataObjects[i] = transactionViewerObject;
            }

            return transactionViewerDataObjects;
        }

        private Bitmap GetBitmapPlusOrMinus(bool isIncome)
        {
            return isIncome ? Resources.plus_16 : Resources.minus_16;
        }

        private void ShowEmptyTransactionTable()
        {
            _transactionView.ShowEmptyTransactions();
        }

        private void DeleteTransaction(object? sender, EventArgs e)
        {
            string title = "Удаление транзакции";
            string text = "Вы действительно хотите удалить выбранную транзакцию?";
            DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TryDeleteTransaction();
            }
        }

        private void TryDeleteTransaction()
        {
            try
            {
                DeleteTransaction();
                UpdateTransactionViewerAndShow();
                NotifyChangeInformationTransaction();
            }
            catch (Exception ex)
            {
                string title = "Ошибка";
                string text = "Произошла критическая ошибка при удалении тразакции!";
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTransaction()
        {
            int transactionId = GetTransactionId();
            _transactionService.DeleteTransaction(transactionId);
        }

        private int GetTransactionId()
        {
            int transactionIndex = _transactionView.GetCurrentTransactionIndex();
            int transactionId = _transactionViewerData[transactionIndex].Id;
            return transactionId;
        }

        private void NotifyChangeInformationTransaction()
        {
            InformationChanged.Invoke(this, EventArgs.Empty);
        }

        private void AddTransaction(object? sender, EventArgs e)
        {
            if (!AnyAccount())
            {
                ShowMessageEmptyAccount();
                return;
            }
            CreateTransactionEdition();
            _transactionEditorPresenter.CreateTransaction();
        }

        private bool AnyAccount()
        {
            List<Account> accounts = _transactionService.GetAccountsByUserId(Session.CurrentUser.Id);
            return accounts.Any();
        }

        private void ShowMessageEmptyAccount()
        {
            string title = "Предупреждение";
            string text = "У вас нет счетов на которых можно провести транзакцию!";
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EditTransaction(object? sender, EventArgs e)
        {
            CreateTransactionEdition();
            int transactionId = GetTransactionId();
            _transactionEditorPresenter.EditTransaction(transactionId);
        }

        private void CreateTransactionEdition()
        {
            TransactionEditorControl transactionEditorControl = new();
            TransactionService transactionService = new();

            _transactionEditorPresenter = new TransactionEditorPresenter(transactionService, transactionEditorControl);
            _transactionEditorPresenter.Apply += Apply;
            _transactionEditorPresenter.Cancel += Cancel;

            _transactionView.ShowTransactionEditorControl(transactionEditorControl);
        }

        private void Apply(object? sender, EventArgs e)
        {
            UpdateTransactionViewerAndShow();
            NotifyChangeInformationTransaction();
            CloseTransactionEditPresenter();
        }

        private void Cancel(object? sender, EventArgs e)
        {
            CloseTransactionEditPresenter();
        }

        public void Close()
        {
            _transactionService.Dispose();
            _transactionViewerService.Dispose();
            CloseTransactionEditPresenter();
        }

        private void CloseTransactionEditPresenter()
        {
            if (_transactionEditorPresenter == null)
                return;

            _transactionView.ClearTransactionEditionControl();
            _transactionEditorPresenter.Close();
            _transactionEditorPresenter.Apply -= Apply;
            _transactionEditorPresenter.Cancel -= Cancel;
            _transactionEditorPresenter = null;
        }

        public Control GetControl()
        {
            return (Control)_transactionView;
        }

        public string GetHeader()
        {
            return "Транзакции";
        }

        public void PressEnter()
        {
            
        }
    }
}
