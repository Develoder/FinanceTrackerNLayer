using FinanceTracker.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private EntitiesContext _entitiesContext;

        public UserRepository(EntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext;
        }

        public void Create(User item)
        {
            _entitiesContext.User.Add(item);
        }

        public void Delete(int id)
        {
            User user = _entitiesContext.User.First(x => x.Id == id);
            _entitiesContext.User.Remove(user);
        }

        public User Get(int id)
        {
            User result = _entitiesContext.User.AsNoTracking().First(x => x.Id == id);
            return result;
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users = _entitiesContext.User.AsNoTracking().AsEnumerable();
            return users;
        }

        public void Update(User item)
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
