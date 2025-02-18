namespace FinanceTracker.UI
{
    public partial class MainForm : Form, IMainFormView
    {
        private Control _control;

        public event EventHandler PressEnter;
        public event EventHandler FormClosingEvent;

        public MainForm()
        {
            InitializeComponent();
            Icon = Resources.app;
        }

        public void ShowWindow(Control control)
        {
            if (_control != null)
            {
                panelPrimaryControl.Controls.Remove(_control);
            }

            _control = control;

            panelPrimaryControl.Controls.Add(_control);
            _control.Dock = DockStyle.Fill;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                PressEnter.Invoke(this, EventArgs.Empty);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormClosingEvent.Invoke(this, EventArgs.Empty);
        }
    }
}