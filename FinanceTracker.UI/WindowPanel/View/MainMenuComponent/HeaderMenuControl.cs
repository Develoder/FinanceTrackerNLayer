namespace FinanceTracker.UI.WindowPanel.View.MainMenuComponent
{
    public partial class HeaderMenuControl : UserControl
    {
        public HeaderMenuControl()
        {
            InitializeComponent();
        }

        public void SetHeader(string header)
        {
            labelHeader.Text = header;
        }
    }
}
