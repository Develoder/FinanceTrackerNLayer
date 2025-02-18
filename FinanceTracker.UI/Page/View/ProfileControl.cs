using FinanceTracker.UI.Page.Interface;

namespace FinanceTracker.UI.Page.View
{
    public partial class ProfileControl : UserControl, IProfileView
    {
        public event EventHandler Close;

        public ProfileControl()
        {
            InitializeComponent();
        }

        public void SetUsername(string username)
        {
            labelUserName.Text = username;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close.Invoke(this, EventArgs.Empty);
        }
    }
}
