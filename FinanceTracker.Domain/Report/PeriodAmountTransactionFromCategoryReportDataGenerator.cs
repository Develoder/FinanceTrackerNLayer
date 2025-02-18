using FinanceTracker.DAL;
using FinanceTracker.Domain.Report.ReportDTO;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.Domain.Report
{
    public class PeriodAmountTransactionFromCategoryReportDataGenerator : IDisposable
    {
        private DateTime _startDate;
        private DateTime _endDate;

        private int _userId;
        private List<CategoryTransaction> _categoryTransactions;
        private List<Transaction> _expenseUserTransactions;
        private List<Transaction> _transactionPeriod;

        private TransactionService _transactionService;

        public PeriodAmountTransactionFromCategoryReportDataGenerator(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public void SetUser(int userId)
        {
            _userId = userId;
            LoadData();
            IncludeCategoryToTrnasaction();
        }

        private void LoadData()
        {
            _categoryTransactions = _transactionService.GetExpenseCategoryTransactions();
            _categoryTransactions.AddRange(_transactionService.GetIncomeCategoryTransactions());
            _expenseUserTransactions = _transactionService.GetExpenseUserTransactions(_userId);
        }

        private void IncludeCategoryToTrnasaction()
        {
            foreach (Transaction transaction in _expenseUserTransactions)
            {
                CategoryTransaction categoryTransaction = _categoryTransactions.First(x => x.Id == transaction.CategoryId);
                transaction.Category = categoryTransaction;
            }
        }

        public void SetData(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;

            FindTransactionPeriod();
        }

        private void FindTransactionPeriod()
        {
            _transactionPeriod = _expenseUserTransactions
                .Where(x => x.Date >= _startDate && x.Date <= _endDate)
                .ToList();
        }

        public bool IsAnyTransactionInPeriod()
        {
            return _transactionPeriod.Any();
        }

        public List<CategoryAmountTransaction> GetTransactionsForDates()
        {
            List<CategoryTransaction> categoryInPeriod = _transactionPeriod
                .GroupBy(x => x.Category)
                .Select(x => x.Key)
                .ToList();

            List<CategoryAmountTransaction> categoryAmountTransactions = new();

            foreach (CategoryTransaction categoryTransaction in categoryInPeriod)
            {
                List<decimal> amountTransaction = _transactionPeriod
                    .Where(x => x.CategoryId == categoryTransaction.Id)
                    .Select(x => x.Amount)
                    .ToList();

                CategoryAmountTransaction categoryAmountTransaction = new(categoryTransaction.Name.Trim(), amountTransaction);
                categoryAmountTransactions.Add(categoryAmountTransaction);
            }

            return categoryAmountTransactions;
        }

        public void Dispose()
        {
            _transactionService.Dispose();
        }
    }
}
