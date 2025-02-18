using FinanceTracker.DAL;

namespace FinanceTracker.DAL.Repository.Interface
{
    public interface IUserRepository : IDisposable
    {
        public IEnumerable<User> GetAll();
        public User Get(int id);
        public void Create(User item);
        public void Update(User item);
        public void Delete(int id);
        public void Save();
    }
}
