using FinanceTracker.UI.WindowPanel.Interface;

namespace FinanceTracker.UI.WindowPanel.View
{
    public partial class LoginControl : UserControl, ILoginView
    {
        public event EventHandler LoginAttempted;
        public event EventHandler RegistrationRequested;

        public string Password { get => tbPassword.Text; set => tbPassword.Text = value; }
        public int UserIndex { get => cbUser.SelectedIndex; set => cbUser.SelectedIndex = value; }

        public LoginControl()
        {
            InitializeComponent();
        }

        public void FillUser(string[] users)
        {
            cbUser.Items.Clear();
            cbUser.Items.AddRange(users);
        }

        public void SetWarningLogin(string warningName)
        {
            labelWarningLogin.Text = warningName;
            cbUser.Focus();
        }

        public void SetWarningPassword(string warningPassword)
        {
            labelWarningPassword.Text = warningPassword;
            tbPassword.Text = string.Empty;
            tbPassword.Focus();
        }

        public void ClearWarningLogin()
        {
            labelWarningLogin.Text = string.Empty;
        }

        public void ClearWarningPassword()
        {
            labelWarningPassword.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAttempted?.Invoke(this, EventArgs.Empty);
        }

        private void llRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
