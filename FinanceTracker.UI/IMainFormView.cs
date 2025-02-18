namespace FinanceTracker.UI
{
    public interface IMainFormView
    {
        public void ShowWindow(Control control);

        public event EventHandler PressEnter;
        public event EventHandler FormClosingEvent;
    }
}
