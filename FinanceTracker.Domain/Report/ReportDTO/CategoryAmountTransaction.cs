namespace FinanceTracker.Domain.Report.ReportDTO
{
    public class CategoryAmountTransaction
    {
        public string CategoryName;
        public List<decimal> Amounts;

        public CategoryAmountTransaction(string categoryName, List<decimal> amounts)
        {
            CategoryName = categoryName;
            Amounts = amounts;
        }
    }
}
