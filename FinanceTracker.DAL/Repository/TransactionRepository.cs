using FinanceTracker.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.DAL.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private EntitiesContext _entitiesContext;

        public TransactionRepository(EntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext;
        }

        public void Create(Transaction item)
        {
            _entitiesContext.Transaction.Add(item);
        }

        public void Delete(int id)
        {
            Transaction transaction = _entitiesContext.Transaction.First(x => x.Id == id);
            _entitiesContext.Transaction.Remove(transaction);
        }

        public Transaction Get(int id)
        {
            Transaction transaction = _entitiesContext.Transaction.AsNoTracking().First(x => x.Id == id);
            return transaction;
        }

        public IEnumerable<Transaction> GetAll()
        {
            IEnumerable<Transaction> transactions = _entitiesContext.Transaction.AsNoTracking().AsEnumerable();
            return transactions;
        }

        public IEnumerable<Transaction> GetTransactionByUserId(int userId)
        {
            IEnumerable<Transaction> transactions = _entitiesContext.Transaction
                .Where(x => x.UserId == userId)
                .AsNoTracking()
                .AsEnumerable();
            return transactions;
        }

        public IEnumerable<Transaction> GetIncomeTransactionByUserId(int userId)
        {
            IEnumerable<Transaction> transactions = _entitiesContext.Transaction
                .Where(x => x.UserId == userId && x.Category.IsIncome)
                .AsNoTracking()
                .AsEnumerable();
            return transactions;
        }

        public IEnumerable<Transaction> GetExpenseTransactionByUserId(int userId)
        {
            IEnumerable<Transaction> transactions = _entitiesContext.Transaction
                .Where(x => x.UserId == userId && !x.Category.IsIncome)
                .AsNoTracking()
                .AsEnumerable();
            return transactions;
        }

        public void Update(Transaction item)
        {
            _entitiesContext.Entry(item).State = EntityState.Modified;
        }

        public void Save()
        {
            _entitiesContext.SaveChanges();
        }

        public void Dispose()
        {
            _entitiesContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
