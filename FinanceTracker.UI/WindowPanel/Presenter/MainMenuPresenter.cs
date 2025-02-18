using FinanceTracker.UI.Page.FactoryMethodContent;
using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.Presenter
{
    public class MainMenuPresenter : IWindowPanel
    {
        private IMainMenuView _mainMenuView;
        private UserAccountBalanceService _userAccountBalanceService;

        private CreatorPage _creatorPage;
        private IPage _page;

        public event EventHandler<CreatorWindowPanel> SetNewWindow;

        public MainMenuPresenter(IMainMenuView mainMenuView, UserAccountBalanceService userAccountBalanceService)
        {
            _mainMenuView = mainMenuView;
            _userAccountBalanceService = userAccountBalanceService;

            _mainMenuView.OpenHomePage += OpenHomePage;
            _mainMenuView.OpenAccountPage += OpenAccountPage;
            _mainMenuView.OpenProfilePage += OpenProfilePage;
            _mainMenuView.OpenTransactionPage += OpenTransactionPage;
            _mainMenuView.OpenReportTransactionPage += OpenReportTransactionPage;
            _mainMenuView.OpenReportCategoryPage += OpenReportCategoryPage;
            Session.UserChanged += UserChanged;

            Initialize();
        }

        private void Initialize()
        {
            _userAccountBalanceService.SetUser(Session.CurrentUser);
            InformationChanged();
            UserChanged();

            SetNewPage(new HomeCreatorPage());
        }

        private void SetNewPage(CreatorPage creatorPage)
        {
            _creatorPage = creatorPage;

            if (_page != null)
            {
                _page.InformationChanged -= InformationChanged;
                _page.Logout -= Logout;
                _page.Close();
            }

            _page = _creatorPage.Create();

            _page.InformationChanged += InformationChanged;
            _page.Logout += Logout;

            SetHeader();
            _mainMenuView.ShowPage(_page.GetControl());
        }

        private void SetHeader()
        {
            _mainMenuView.SetHeader(_page.GetHeader());
        }

        private void InformationChanged(object? sender, EventArgs e)
        {
            InformationChanged();
        }

        private void InformationChanged()
        {
            _userAccountBalanceService.UpdateInformationBalanced();
            if (_userAccountBalanceService.IsHasAccount)
            {
                _mainMenuView.SetBalanceInformation(_userAccountBalanceService.Balance);
            }
            else
            {
                _mainMenuView.SetEmptyAccountInformation("Нет счетов");
            }
        }

        private void Logout(object? sender, EventArgs e)
        {
            SetNewWindow.Invoke(this, new LoginCreatorWindowPanel());
        }

        private void UserChanged()
        {
            _mainMenuView.SetUserInformation(Session.CurrentUser.Name);
        }

        private void OpenHomePage(object? sender, EventArgs e)
        {
            SetNewPage(new HomeCreatorPage());
        }

        private void OpenAccountPage(object? sender, EventArgs e)
        {
            SetNewPage(new AccountCreatorPage());
        }

        private void OpenTransactionPage(object? sender, EventArgs e)
        {
            SetNewPage(new TransactionCreatorPage());
        }

        private void OpenReportCategoryPage(object? sender, EventArgs e)
        {
            SetNewPage(new PeriodCircleCategoryTransactionPresenterCreatorPage());
        }

        private void OpenReportTransactionPage(object? sender, EventArgs e)
        {
            SetNewPage(new PeriodTransactionForEveryDayCreatorPage());
        }

        private void OpenProfilePage(object? sender, EventArgs e)
        {
            SetNewPage(new ProfileCreatorPage());
        }

        public void PressEnter()
        {
            _page.PressEnter();
        }

        public Control GetControl()
        {
            return (Control)_mainMenuView;
        }
    }
}
