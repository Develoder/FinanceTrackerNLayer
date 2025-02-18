using FinanceTracker.DAL;

namespace FinanceTracker.DAL.Repository.Interface
{
    public interface ITypeAccountRepository : IDisposable
    {
        public IEnumerable<TypeAccount> GetAll();
        public TypeAccount Get(int id);
        public void Create(TypeAccount item);
        public void Update(TypeAccount item);
        public void Delete(int id);
        public void Save();
    }
}
