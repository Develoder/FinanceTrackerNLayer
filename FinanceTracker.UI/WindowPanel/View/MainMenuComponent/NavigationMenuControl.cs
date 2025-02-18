using System.ComponentModel;

namespace FinanceTracker.UI.WindowPanel.View.MainMenuComponent
{
    public partial class NavigationMenuControl : UserControl
    {
        [Category("MenuEvent")]
        public event EventHandler OpenHomePage;
        [Category("MenuEvent")]
        public event EventHandler OpenProfilePage;
        [Category("MenuEvent")]
        public event EventHandler OpenAccountPage;
        [Category("MenuEvent")]
        public event EventHandler OpenTransactionPage;
        [Category("MenuEvent")]
        public event EventHandler OpenReportTransactionPage;
        [Category("MenuEvent")]
        public event EventHandler OpenReportCategoryPage;

        public NavigationMenuControl()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            cpReport.InitializationStartParameters();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            cpReport.ExecuteCollapse();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenHomePage.Invoke(this, EventArgs.Empty);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            OpenProfilePage.Invoke(this, EventArgs.Empty);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            OpenAccountPage.Invoke(this, EventArgs.Empty);
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            OpenTransactionPage.Invoke(this, EventArgs.Empty);
        }

        private void buttonReportTransaction_Click(object sender, EventArgs e)
        {
            OpenReportTransactionPage.Invoke(this, EventArgs.Empty);
        }

        private void buttonReportCategory_Click(object sender, EventArgs e)
        {
            OpenReportCategoryPage.Invoke(this, EventArgs.Empty);
        }
    }
}
