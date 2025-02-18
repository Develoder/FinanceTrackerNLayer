using FinanceTracker.UI.Page.Interface;
using ScottPlot;

namespace FinanceTracker.UI.Page.View
{
    public partial class ReportControl : UserControl, IReportView
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        public Plot GetPlot()
        {
            return formsPlot1.Plot;
        }

        public void SetReportInputControl(Control periodTransactionInputView)
        {
            tlpMain.Controls.Add(periodTransactionInputView, 0, 0);
        }
    }
}
