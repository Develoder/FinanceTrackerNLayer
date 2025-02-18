namespace FinanceTracker.UI.ReportInputPanel.Interface
{
    public interface IPeriodTransactionInputView
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate {  get; set; }

        public event EventHandler Applay;
    }                   
}
