namespace FinanceTracker.UI.Page.Interface
{
    public interface IProfileView
    {
        public void SetUsername(string username);
        public event EventHandler Close;
    }
}
