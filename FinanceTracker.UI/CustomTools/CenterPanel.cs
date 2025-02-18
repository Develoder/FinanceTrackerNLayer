namespace FinanceTracker.UI.CustomTools
{
    public partial class CenterPanel : UserControl
    {
        private Control _control;

        public CenterPanel()
        {
            InitializeComponent();
        }

        public void Add(Control control)
        {
            if (_control != null)
                tlpCenterPanel.Controls.Remove(_control);
            _control = control;
            tlpCenterPanel.Controls.Add(control, 1, 1);
        }

        public void Clear()
        {
            if (_control != null)
            {
                tlpCenterPanel.Controls.Remove(_control);
                _control.Dispose();
            }
        }
    }
}
