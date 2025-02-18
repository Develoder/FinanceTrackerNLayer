namespace FinanceTracker.UI.WindowPanel.Interface
{
    public interface ILoginView
    {
        public string Password { get; set; }
        public int UserIndex { get; set; }

        public void FillUser(string[] users);
        public void SetWarningLogin(string warningName);
        public void SetWarningPassword(string warningPassword);
        public void ClearWarningLogin();
        public void ClearWarningPassword();

        public event EventHandler LoginAttempted;
        public event EventHandler RegistrationRequested;
    }
}
