using FinanceTracker.UI.WindowPanel.Interface;

namespace FinanceTracker.UI.Page.Interface
{
    public interface IPage : ISenderEnter
    {
        public string GetHeader();
        public Control GetControl();
        public void Close();

        public event EventHandler InformationChanged;
        public event EventHandler Logout;
    }
}
