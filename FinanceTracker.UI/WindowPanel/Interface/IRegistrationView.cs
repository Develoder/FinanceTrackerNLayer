namespace FinanceTracker.UI.WindowPanel.Interface
{
    public interface IRegistrationView
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }

        public void SetWarningLogin(string warningMessage);
        public void SetWarningPassword(string warningMessage);
        public void SetWarningRepeatPassword(string warningMessage);
        public void ClearWarningLogin();
        public void ClearWarningPassword();
        public void ClearWarningRepeatPassword();

        public event EventHandler LoginLeave;
        public event EventHandler PasswordChanged;
        public event EventHandler RepeatPasswordChanged;
        public event EventHandler MakeRegistration;
        public event EventHandler ReturnLoginWindow;
    }
}
