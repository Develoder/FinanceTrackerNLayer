namespace FinanceTracker.DAL.Repository.Interface
{
    public interface IAccountRepository : IDisposable
    {
        public IEnumerable<Account> GetAll();
        public IEnumerable<Account> GetAccountsByUserId(int userId);
        public Account Get(int id);
        public void Create(Account item);
        public void Update(Account item);
        public void Delete(int id);
        public void Save();
    }
}
