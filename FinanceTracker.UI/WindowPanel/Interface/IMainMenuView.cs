namespace FinanceTracker.UI.WindowPanel.Interface
{
    public interface IMainMenuView
    {
        public void SetHeader(string header);
        public void ShowPage(Control control);
        public void SetUserInformation(string username);
        public void SetBalanceInformation(decimal balance);
        public void SetEmptyAccountInformation(string information);

        public event EventHandler OpenHomePage;
        public event EventHandler OpenAccountPage;
        public event EventHandler OpenTransactionPage;
        public event EventHandler OpenProfilePage;
        public event EventHandler OpenReportTransactionPage;
        public event EventHandler OpenReportCategoryPage;
    }
}
