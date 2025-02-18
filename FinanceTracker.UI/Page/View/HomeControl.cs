using FinanceTracker.UI.Page.Interface;

namespace FinanceTracker.UI.Page.View
{
    public partial class HomeControl : UserControl, IHomeView
    {
        public HomeControl()
        {
            InitializeComponent();

        }

        public void ShowInformation(string text)
        {
            labelText.Text = text;
        }
    }
}
