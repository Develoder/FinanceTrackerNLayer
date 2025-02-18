namespace FinanceTracker.UI.WindowPanel.View.MainMenuComponent
{
    public partial class InformationMenuControl : UserControl
    {
        public InformationMenuControl()
        {
            InitializeComponent();
        }

        public void SetBalanceInformation(string text)
        {
            labelBalance.Text = text;

        }

        public void SetUserInformation(string username)
        {
            labelUserName.Text = username.Trim();
        }
    }
}
