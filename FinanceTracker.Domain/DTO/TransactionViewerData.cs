using FinanceTracker.DAL;

namespace FinanceTracker.Domain.DTO
{
    public class TransactionViewerData
    {
        public int Id;
        public bool IsIncome;
        public decimal Amount;
        public string TransactionCategoryName;
        public DateTime DateTime;
        public string Description;
        public string AccountName;

        public static TransactionViewerData Map(Transaction transaction)
        {
            return new TransactionViewerData
            {
                Id = transaction.Id,
                IsIncome = transaction.Category.IsIncome,
                Amount = transaction.Amount,
                TransactionCategoryName = transaction.Category.Name,
                DateTime = transaction.Date,
                Description = transaction.Description,
                AccountName = transaction.Account.Name
            };
        }
    }
}
