using FinanceTracker.DAL;
using FinanceTracker.Domain.DTO;

namespace FinanceTracker.Domain.Service
{
    public class TransactionViewerService : IDisposable
    {
        private TransactionService _transactionService;

        private int _userId;

        private List<Transaction> _transactions;
        private List<CategoryTransaction> _categoryTransactions;
        private List<Account> _accounts;

        public TransactionViewerService()
        {
            _transactionService = new();
        }

        public TransactionViewerService(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public void SetUserId(int userId)
        {
            _userId = userId;
        }

        public void LoadData()
        {
            _accounts = _transactionService.GetAccountsByUserId(_userId);
            _transactions = _transactionService.GetUserTransactions(_userId);
            _categoryTransactions = _transactionService.GetIncomeCategoryTransactions();
            _categoryTransactions.AddRange(_transactionService.GetExpenseCategoryTransactions());
        }

        public bool AnyTransactions()
        {
           return _transactions.Any();
        }

        public List<TransactionViewerData> GetAllAccountViewerData()
        {
            List<TransactionViewerData> transactionViewersData = new();
            foreach (Transaction transaction in _transactions)
            {
                Account account = _accounts.First(x => x.Id == transaction.AccountId);
                CategoryTransaction categoryTransaction = _categoryTransactions.First(x => x.Id == transaction.CategoryId);

                transaction.Account = account;
                transaction.Category = categoryTransaction;

                TransactionViewerData transactionViewerData = TransactionViewerData.Map(transaction);
                transactionViewersData.Add(transactionViewerData);
            }

            return transactionViewersData;
        }

        public void Dispose()
        {
            _transactionService.Dispose();
        }
    }
}
