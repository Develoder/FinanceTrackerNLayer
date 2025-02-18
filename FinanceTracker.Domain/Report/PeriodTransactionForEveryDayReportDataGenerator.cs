using FinanceTracker.DAL;
using FinanceTracker.Domain.Report.ReportDTO;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.Domain.Report
{
    public class PeriodTransactionForEveryDayReportDataGenerator : IDisposable
    {
        private DateTime _startDate;
        private DateTime _endDate;

        private int _userId;
        private List<CategoryTransaction> _categoryTransactions;
        private List<Transaction> _allUserTransactions;
        private List<Transaction> _transactionPeriod;

        private TransactionService _transactionService;

        public PeriodTransactionForEveryDayReportDataGenerator(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public void SetUser(int userId)
        {
            _userId = userId;
            LoadData();
            IncludeCategoryToTransaction();
        }

        private void LoadData()
        {
            _categoryTransactions = _transactionService.GetExpenseCategoryTransactions();
            _categoryTransactions.AddRange(_transactionService.GetIncomeCategoryTransactions());
            _allUserTransactions = _transactionService.GetUserTransactions(_userId);
        }

        private void IncludeCategoryToTransaction()
        {
            foreach (Transaction transaction in _allUserTransactions)
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
            _transactionPeriod = _allUserTransactions
                .Where(x => x.Date >= _startDate && x.Date <= _endDate)
                .ToList();
        }

        public bool IsAnyTransactionInPeriod()
        {
            return _transactionPeriod.Any();
        }

        public List<TransactionsForDate> GetTransactionsForDates()
        {
            var dateRange = Enumerable.Range(0, (_endDate - _startDate).Days + 1)
                          .Select(offset => _startDate.AddDays(offset));

            List<TransactionsForDate> transactionsForDates = new();
            foreach (DateTime date in dateRange)
            {
                List<Transaction> transactionsInDay = _transactionPeriod
                    .Where(x => x.Date.Date == date.Date)
                    .ToList();

                List<decimal> amountTransactions = transactionsInDay
                    .Select(GetAmountTransaction)
                    .ToList();

                TransactionsForDate transactionsForDate = new(date, amountTransactions);
                transactionsForDates.Add(transactionsForDate);
            }

            return transactionsForDates;
        }

        private decimal GetAmountTransaction(Transaction transaction)
        {
            return transaction.Category.IsIncome ? transaction.Amount : -transaction.Amount;
        }

        public void Dispose()
        {
            _transactionService.Dispose();
        }
    }
}
