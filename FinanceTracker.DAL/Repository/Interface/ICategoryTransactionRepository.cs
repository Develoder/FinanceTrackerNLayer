using FinanceTracker.DAL;

namespace FinanceTracker.DAL.Repository.Interface
{
    public interface ICategoryTransactionRepository : IDisposable
    {
        public IEnumerable<CategoryTransaction> GetAll();
        public CategoryTransaction Get(int id);
        public void Create(CategoryTransaction item);
        public void Update(CategoryTransaction item);
        public void Delete(int id);
        public void Save();
    }
}
