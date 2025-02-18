using ScottPlot;

namespace FinanceTracker.UI.Page.Interface
{
    public interface IReportView
    {
        public Plot GetPlot();
        void SetReportInputControl(Control periodTransactionInputView);
    }
}
