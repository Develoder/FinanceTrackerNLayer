using FinanceTracker.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.DAL.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private EntitiesContext _entitiesContext;

        public AccountRepository(EntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext;
        }

        public void Create(Account item)
        {
            _entitiesContext.Account.Add(item);
        }

        public void Delete(int id)
        {
            Account account = _entitiesContext.Account.Include(x => x.Transaction).First();
            _entitiesContext.Account.Remove(account);
        }

        public Account Get(int id)
        {
            Account result = _entitiesContext.Account.AsNoTracking().First(x => x.Id == id);
            return result;
        }

        public IEnumerable<Account> GetAll()
        {
            IEnumerable<Account> accounts = _entitiesContext.Account.AsNoTracking().AsEnumerable();
            return accounts;
        }

        public IEnumerable<Account> GetAccountsByUserId(int userId)
        {
            IEnumerable<Account> accounts = _entitiesContext.Account
                .Where(x => x.UserId == userId)
                .AsNoTracking()
                .AsEnumerable();
            return accounts;
        }

        public void Update(Account item)
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
