using FinanceTracker.UI.WindowPanel.Interface;

namespace FinanceTracker.UI.WindowPanel.View
{
    public partial class MainMenuControl : UserControl, IMainMenuView
    {
        private Control _control;

        public event EventHandler OpenHomePage;
        public event EventHandler OpenProfilePage;
        public event EventHandler OpenTransactionPage;
        public event EventHandler OpenAccountPage;
        public event EventHandler OpenReportTransactionPage;
        public event EventHandler OpenReportCategoryPage;

        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            cpMenu.ExecuteCollapse();
        }

        private void MainPrimaryControl_Load(object sender, EventArgs e)
        {
            nmcNavigationMenu.Initialize();
            cpMenu.InitializationStartParameters();
        }

        public void SetHeader(string header)
        {
            hmcHeader.SetHeader(header);
        }

        public void ShowPage(Control control)
        {
            panelContent.Controls.Remove(_control);
            _control = control;

            panelContent.Controls.Add(_control);
            _control.Dock = DockStyle.Fill;
        }

        public void SetUserInformation(string username)
        {
            imcInformation.SetUserInformation(username);
        }

        public void SetBalanceInformation(decimal balance)
        {
            imcInformation.SetBalanceInformation($"{balance:#,##0.##} ₽");
        }

        public void SetEmptyAccountInformation(string information)
        {
            imcInformation.SetBalanceInformation(information);
        }

        private void nmcNavigationMenu_OpenHomePage(object sender, EventArgs e)
        {
            OpenHomePage.Invoke(this, EventArgs.Empty);
        }

        private void nmcNavigationMenu_OpenProfilePage(object sender, EventArgs e)
        {
            OpenProfilePage.Invoke(this, EventArgs.Empty);
        }

        private void nmcNavigationMenu_OpenAccountPage(object sender, EventArgs e)
        {
            OpenAccountPage.Invoke(this, EventArgs.Empty);
        }

        private void nmcNavigationMenu_OpenTransactionPage(object sender, EventArgs e)
        {
            OpenTransactionPage.Invoke(this, EventArgs.Empty);
        }

        private void nmcNavigationMenu_OpenReportTransactionPage(object sender, EventArgs e)
        {
            OpenReportTransactionPage.Invoke(this, EventArgs.Empty);
        }

        private void nmcNavigationMenu_OpenReportCategoryPage(object sender, EventArgs e)
        {
            OpenReportCategoryPage.Invoke(this, EventArgs.Empty);
        }
    }
}
