namespace FinanceTracker.UI.Page.Interface
{
    public interface IAccountView
    {
        public void ShowAccounts(object[][] accountViewerDataObjects);
        public void ShowEmptyAccounts();
        public int GetCurrentAccountIndex();
        public void ShowAccountEditorControl(Control editionControl);
        public void ClearAccountEditionControl();

        public event EventHandler AddAccount;
        public event EventHandler DeleteAccount;
        public event EventHandler EditAccount;
    }
}
