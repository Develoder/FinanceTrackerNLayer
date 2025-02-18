namespace FinanceTracker.UI.EditionPanel.View.Interface
{
    public interface IAccountEditorView
    {
        public string AccountName { get; set; }
        public int IndexTypeAccount { get; set; }

        public void SetAllTypeAccount(string[] nameTypeAccounts);
        public void CreateAccount();

        public void ShowWarning(string text);
        public void ClearWarning();

        public event EventHandler Cancel;
        public event EventHandler Apply;
    }
}
