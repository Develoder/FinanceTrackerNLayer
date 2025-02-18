namespace FinanceTracker.UI.ReportInputPanel.Interface
{
    public interface IPeriodCategoryInputView
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate {  get; set; }

        public event EventHandler Applay;
    }                   
}
