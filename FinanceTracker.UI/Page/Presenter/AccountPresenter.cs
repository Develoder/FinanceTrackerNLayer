using FinanceTracker.UI.EditionPanel.View;
using FinanceTracker.UI.EditionPanel.View.Presenter;
using FinanceTracker.UI.Page.Interface;
using FinanceTracker.Domain.DTO;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.Presenter
{
    public class AccountPresenter : IPage
    {
        private IAccountView _accountView;
        private AccountViewerService _accountViewerService;
        private AccountService _accountService;

        private List<AccountViewerData> _accountViewersData;
        private AccountEditorPresenter _accountEditorPresenter;

        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public AccountPresenter(IAccountView accountView, AccountViewerService accountViewerService, AccountService accountService)
        {
            _accountView = accountView;
            _accountViewerService = accountViewerService;
            _accountService = accountService;

            _accountView.AddAccount += AddAccount;
            _accountView.DeleteAccount += DeleteAccount;
            _accountView.EditAccount += EditAccount;

            Initialize();
        }

        private void Initialize()
        {
            _accountViewerService.SetUserId(Session.CurrentUser.Id);
            UpdateAccountViewerAndShow();
        }

        private void UpdateAccountViewerAndShow()
        {
            _accountViewerService.LoadData();

            if (_accountViewerService.AnyAccount())
                ShowAccountTable();
            else
                ShowEmptyAccountTable();
        }

        private void ShowAccountTable()
        {
            _accountViewersData = _accountViewerService.GetAllAccountViewerData();
            object[][] accountViewerObjects = GenerateAccountViewerDataObjects();
            _accountView.ShowAccounts(accountViewerObjects);
        }

        private object[][] GenerateAccountViewerDataObjects()
        {
            object[][] accountViewerDataObjects = new object[_accountViewersData.Count][];
            for (int i = 0; i < _accountViewersData.Count; i++)
            {
                AccountViewerData accountViewerData = _accountViewersData[i];
                object[] accountViewerObject = [accountViewerData.Name, accountViewerData.TypeName, accountViewerData.Balance];
                accountViewerDataObjects[i] = accountViewerObject;
            }

            return accountViewerDataObjects;
        }

        private void ShowEmptyAccountTable()
        {
            _accountView.ShowEmptyAccounts();
        }

        private void DeleteAccount(object? sender, EventArgs e)
        {
            string title = "Удаление счета";
            string text = "Вы действительно хотите удалить выбранный счет со всеми транзакциями?";
            DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TryDeleteAccount();
            }
        }

        private void TryDeleteAccount()
        {
            try
            {
                DeleteAccount();
                UpdateAccountViewerAndShow();
                NotifyChangeInformationAccount();
            }
            catch (Exception ex)
            {
                string title = "Ошибка";
                string text = "Произошла критическая ошибка при удалении счета!";
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAccount()
        {
            int accountId = GetAccountId();
            _accountService.DeleteAccount(accountId);
        }

        private void NotifyChangeInformationAccount()
        {
            InformationChanged.Invoke(this, EventArgs.Empty);
        }

        private int GetAccountId()
        {
            int accountIndex = _accountView.GetCurrentAccountIndex();
            int accountId = _accountViewersData[accountIndex].Id;
            return accountId;
        }

        private void AddAccount(object? sender, EventArgs e)
        {
            CreateAccountEdition();
            _accountEditorPresenter.CreateAccount();
        }

        private void EditAccount(object? sender, EventArgs e)
        {
            CreateAccountEdition();
            int accountId = GetAccountId();
            _accountEditorPresenter.EditAccount(accountId);
        }

        private void CreateAccountEdition()
        {
            AccountEditorControl accountEditionControl = new();
            AccountService accountService = new();
            _accountEditorPresenter = new AccountEditorPresenter(accountEditionControl, accountService);
            _accountEditorPresenter.Apply += Apply;
            _accountEditorPresenter.Cancel += Cancel;

            _accountView.ShowAccountEditorControl(accountEditionControl);
        }

        private void Apply(object? sender, EventArgs e)
        {
            UpdateAccountViewerAndShow();
            NotifyChangeInformationAccount();
            CloseAccountEditPresenter();
        }

        private void Cancel(object? sender, EventArgs e)
        {
            CloseAccountEditPresenter();
        }

        public void Close()
        {
            _accountService.Dispose();
            _accountViewerService.Dispose();
            CloseAccountEditPresenter();
        }

        private void CloseAccountEditPresenter()
        {
            if (_accountEditorPresenter == null)
                return;

            _accountView.ClearAccountEditionControl();
            _accountEditorPresenter.Close();
            _accountEditorPresenter.Apply -= Apply;
            _accountEditorPresenter.Cancel -= Cancel;
            _accountEditorPresenter = null;
        }

        public string GetHeader()
        {
            return "Счета";
        }

        public Control GetControl()
        {
            return (Control)_accountView;
        }

        public void PressEnter()
        {
            
        }
    }
}
