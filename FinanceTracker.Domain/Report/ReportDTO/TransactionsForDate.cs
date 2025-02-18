namespace FinanceTracker.Domain.Report.ReportDTO
{
    public class TransactionsForDate
    {
        public DateTime DateTime;
        public List<decimal> AmountTransactions;

        public TransactionsForDate(DateTime dateTime, List<decimal> amountTransactions)
        {
            DateTime = dateTime;
            AmountTransactions = amountTransactions;
        }
    }
}
