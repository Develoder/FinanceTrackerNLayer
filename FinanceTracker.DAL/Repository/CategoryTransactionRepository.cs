using FinanceTracker.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.DAL.Repository
{
    public class CategoryTransactionRepository : ICategoryTransactionRepository
    {
        private EntitiesContext _entitiesContext;

        public CategoryTransactionRepository(EntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext;
        }

        public void Create(CategoryTransaction item)
        {
            _entitiesContext.CategoryTransaction.Add(item);
        }

        public void Delete(int id)
        {
            CategoryTransaction categoryTransaction = _entitiesContext.CategoryTransaction.First(x => x.Id == id);
            _entitiesContext.CategoryTransaction.Remove(categoryTransaction);
        }

        public CategoryTransaction Get(int id)
        {
            CategoryTransaction categoryTransaction = _entitiesContext.CategoryTransaction.AsNoTracking().First(x => x.Id == id);
            return categoryTransaction;
        }

        public IEnumerable<CategoryTransaction> GetAll()
        {
            IEnumerable<CategoryTransaction> categoryTransactions = _entitiesContext.CategoryTransaction.AsNoTracking().AsEnumerable();
            return categoryTransactions;
        }

        public void Update(CategoryTransaction item)
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
