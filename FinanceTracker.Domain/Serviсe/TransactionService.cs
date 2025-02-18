using FinanceTracker.DAL;
using FinanceTracker.DAL.UnitOfWork;
using FinanceTracker.DAL.UnitOfWork.Interface;

namespace FinanceTracker.Domain.Service
{
    public class TransactionService : IDisposable
    {
        private ITransactionUnitOfWork _transactionUnitOfWork;

        public TransactionService()
        {
            _transactionUnitOfWork = new TransactionUnitOfWork();
        }

        public List<Transaction> GetUserTransactions(int userId)
        {
            List<Transaction> userTransactions = _transactionUnitOfWork.TransactionRepository
                .GetTransactionByUserId(userId)
                .ToList();

            return userTransactions;
        }

        public List<Transaction> GetIncomeUserTransactions(int userId)
        {
            List<Transaction> userTransactions = _transactionUnitOfWork.TransactionRepository
                .GetIncomeTransactionByUserId(userId)
                .ToList();

            return userTransactions;
        }

        public List<Transaction> GetExpenseUserTransactions(int userId)
        {
            List<Transaction> userTransactions = _transactionUnitOfWork.TransactionRepository
                .GetExpenseTransactionByUserId(userId)
                .ToList();

            return userTransactions;
        }

        public Transaction GetTransaction(int transactionId)
        {
            Transaction transaction = _transactionUnitOfWork.TransactionRepository
                .Get(transactionId);

            return transaction;
        }

        public CategoryTransaction GetCategoryTransaction(int categoryId)
        {
            CategoryTransaction categoryTransaction = _transactionUnitOfWork.CategoryTransactionRepository
                .Get(categoryId);

            return categoryTransaction;
        }

        public List<Account> GetAccountsByUserId(int userId)
        {
            List<Account> accounts = _transactionUnitOfWork.AccountRepository
                .GetAccountsByUserId(userId)
                .ToList();

            return accounts;
        }

        public List<CategoryTransaction> GetIncomeCategoryTransactions()
        {
            List<CategoryTransaction> categoryTransactions = _transactionUnitOfWork
                .CategoryTransactionRepository
                .GetAll()
                .Where(x => x.IsIncome)
                .ToList();

            return categoryTransactions;
        }

        public List<CategoryTransaction> GetExpenseCategoryTransactions()
        {
            List<CategoryTransaction> categoryTransactions = _transactionUnitOfWork
                .CategoryTransactionRepository
                .GetAll()
                .Where(x => !x.IsIncome)
                .ToList();

            return categoryTransactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            ClearTransaction(transaction);

            _transactionUnitOfWork.TransactionRepository.Create(transaction);

            decimal amountDifference = GetNewAmountDifference(transaction);
            ChangeBalanceAccount(transaction.AccountId, amountDifference);

            _transactionUnitOfWork.Save();
        }

        private decimal GetNewAmountDifference(Transaction transaction)
        {
            CategoryTransaction categoryTransaction = _transactionUnitOfWork.CategoryTransactionRepository.Get(transaction.CategoryId);
            CalculationChangeBalanceAccount calculationChangeBalanceAccount = new(categoryTransaction.IsIncome, transaction.Amount);
            decimal newAmountDifference = calculationChangeBalanceAccount.GetAmountDifference();

            return newAmountDifference;
        }

        public void UpdateTransaction(Transaction editedTransaction)
        {
            ClearTransaction(editedTransaction);

            _transactionUnitOfWork.TransactionRepository.Update(editedTransaction);

            decimal amountDifference = GetUpdateAmountDifference(editedTransaction);
            ChangeBalanceAccount(editedTransaction.AccountId, amountDifference);

            _transactionUnitOfWork.Save();
        }

        private decimal GetUpdateAmountDifference(Transaction editedTransaction)
        {
            Transaction oldTransaction = _transactionUnitOfWork.TransactionRepository.Get(editedTransaction.Id);
            CategoryTransaction oldCategoryTransaction = _transactionUnitOfWork.CategoryTransactionRepository.Get(oldTransaction.CategoryId);
            CategoryTransaction editedCategoryTransaction = _transactionUnitOfWork.CategoryTransactionRepository.Get(editedTransaction.CategoryId);

            CalculationChangeBalanceAccount calculationChangeBalanceAccount = new(oldCategoryTransaction.IsIncome, oldTransaction.Amount);
            calculationChangeBalanceAccount.SetUpdatedTransaction(editedCategoryTransaction.IsIncome, editedTransaction.Amount);
            decimal editedAmountDifference = calculationChangeBalanceAccount.GetAmountDifference();

            return editedAmountDifference;
        }

        private void ChangeBalanceAccount(int accountId, decimal amount)
        {
            Account account = _transactionUnitOfWork.AccountRepository.Get(accountId);
            account.Balance += amount;
            _transactionUnitOfWork.AccountRepository.Update(account);
        }

        private void ClearTransaction(Transaction transaction)
        {
            transaction.User = null;
            transaction.Category = null;
            transaction.Account = null;
        }

        public void DeleteTransaction(int transactionId)
        {
            _transactionUnitOfWork.TransactionRepository.Delete(transactionId);
            _transactionUnitOfWork.Save();
        }

        public void Dispose()
        {
            _transactionUnitOfWork.Dispose();
        }
    }
}
