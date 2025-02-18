using FinanceTracker.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.DAL.Repository
{
    public class TypeAccountRepository : ITypeAccountRepository
    {
        private EntitiesContext _entitiesContext;

        public TypeAccountRepository(EntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext;
        }

        public void Create(TypeAccount item)
        {
            _entitiesContext.TypeAccount.Add(item);
        }

        public void Delete(int id)
        {
            TypeAccount typeAccount = _entitiesContext.TypeAccount.First(x => x.Id == id);
            _entitiesContext.TypeAccount.Remove(typeAccount);
        }

        public TypeAccount Get(int id)
        {
            TypeAccount typeAccount = _entitiesContext.TypeAccount.AsNoTracking().First(x => x.Id == id);
            return typeAccount;
        }

        public IEnumerable<TypeAccount> GetAll()
        {
            IEnumerable<TypeAccount> typeAccounts = _entitiesContext.TypeAccount.AsNoTracking().AsEnumerable();
            return typeAccounts;
        }

        public void Update(TypeAccount item)
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
