using FinanceTracker.UI.WindowPanel.Interface;

namespace FinanceTracker.UI.WindowPanel.View
{
    public partial class RegistrationControl : UserControl, IRegistrationView
    {
        public string Login { get => tbLogin.Text; set => tbLogin.Text = value; }
        public string Password { get => tbPassword.Text; set => tbPassword.Text = value; }
        public string RepeatPassword { get => tbRepeatPassword.Text; set => tbRepeatPassword.Text = value; }

        public event EventHandler LoginLeave;
        public event EventHandler PasswordChanged;
        public event EventHandler RepeatPasswordChanged;
        public event EventHandler MakeRegistration;
        public event EventHandler ReturnLoginWindow;

        private System.Windows.Forms.Timer _debounceTimer;
        private delegate void CallTextChanged();
        private CallTextChanged _callTextChanged;
        private const int INTERVAL = 1000;

        public RegistrationControl()
        {
            InitializeComponent();

            _debounceTimer = new();
            _debounceTimer.Interval = INTERVAL;
            _debounceTimer.Tick += debounceTimer_Tick;
        }

        private void debounceTimer_Tick(object? sender, EventArgs e)
        {
            _debounceTimer.Stop();
            _callTextChanged.Invoke();
        }

        private void buttonRegistered_Click(object sender, EventArgs e)
        {
            MakeRegistration?.Invoke(this, EventArgs.Empty);
        }

        private void tpPassword_TextChanged(object sender, EventArgs e)
        {
            RestartTimerTextChanged(PasswordTextChanged);
        }

        private void tbRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            RestartTimerTextChanged(RepeatPasswordTextChanged);
        }

        private void RestartTimerTextChanged(CallTextChanged callTextChanged)
        {
            _callTextChanged = callTextChanged;
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void PasswordTextChanged()
        {
            PasswordChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RepeatPasswordTextChanged()
        {
            RepeatPasswordChanged?.Invoke(this, EventArgs.Empty);
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            LoginLeave?.Invoke(this, EventArgs.Empty);
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnLoginWindow?.Invoke(this, EventArgs.Empty);
        }

        public void SetWarningLogin(string warningMessage)
        {
            labelWarningLogin.Text = warningMessage;
            labelWarningLogin.Visible = true;
        }

        public void SetWarningPassword(string warningMessage)
        {
            labelWarningPassword.Text = warningMessage;
            labelWarningPassword.Visible = true;
        }

        public void SetWarningRepeatPassword(string warningMessage)
        {
            labelWarningRepeatPassword.Text = warningMessage;
            labelWarningRepeatPassword.Visible = true;
        }

        public void ClearWarningLogin()
        {
            labelWarningLogin.Text = string.Empty;
            labelWarningLogin.Visible = false;
        }

        public void ClearWarningPassword()
        {
            labelWarningPassword.Text = string.Empty;
            labelWarningPassword.Visible = false;
        }

        public void ClearWarningRepeatPassword()
        {
            labelWarningRepeatPassword.Text = string.Empty;
            labelWarningRepeatPassword.Visible = false;
        }
    }
}
