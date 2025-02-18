using FinanceTracker.UI.ReportInputPanel.Interface;

namespace FinanceTracker.UI.ReportInputPanel.View
{
    public partial class PeriodCategoryInputControl : UserControl, IPeriodCategoryInputView
    {
        public DateTime StartDate { get => dtpStart.Value; set => dtpStart.Value = value; }
        public DateTime EndDate { get => dtpEnd.Value; set => dtpEnd.Value = value; }

        public event EventHandler Applay;

        public PeriodCategoryInputControl()
        {
            InitializeComponent();
        }

        private void buttonApplay_Click(object sender, EventArgs e)
        {
            Applay.Invoke(this, EventArgs.Empty);
        }
    }
}
