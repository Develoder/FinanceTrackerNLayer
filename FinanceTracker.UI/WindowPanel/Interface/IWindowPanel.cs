using FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel;

namespace FinanceTracker.UI.WindowPanel.Interface
{
    public interface IWindowPanel : ISenderEnter
    {
        public Control GetControl();
        public event EventHandler<CreatorWindowPanel> SetNewWindow;
    }
}
