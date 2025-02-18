namespace FinanceTracker.DAL.Repository.Interface
{
    public interface ITransactionRepository : IDisposable
    {
        public IEnumerable<Transaction> GetAll();
        public Transaction Get(int id);
        public IEnumerable<Transaction> GetTransactionByUserId(int userId);
        public IEnumerable<Transaction> GetIncomeTransactionByUserId(int userId);
        public IEnumerable<Transaction> GetExpenseTransactionByUserId(int userId);
        public void Create(Transaction item);
        public void Update(Transaction item);
        public void Delete(int id);
        public void Save();
    }
}
