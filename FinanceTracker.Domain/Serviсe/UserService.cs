using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository;
using FinanceTracker.DAL.Repository.Interface;

namespace FinanceTracker.Domain.Service
{
    public class UserService : IDisposable
    {
        public const int MAX_LEN_LOGIN = 20;

        private readonly IUserRepository _userRepository;

        public UserService()
        {
            EntitiesContext db = new();
            _userRepository = new UserRepository(db);
        }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUser()
        {
            List<User> users = _userRepository.GetAll().ToList();
            return users;
        }

        public bool AnyUser()
        {
            return _userRepository.GetAll().Any();
        }

        public User GetUserLogin(string login)
        {
            User user = _userRepository.GetAll()
                .Where(x => x.Name.Trim() == login)
                .First();
            return user;
        }

        public bool IsCorrectUserPassword(string verifiablePassword, string installedPassword)
        {
            string hashPassword = PasswordConverter.GetHashPassword(verifiablePassword);
            return installedPassword == hashPassword;
        }

        public void AddUser(string username, string password)
        {
            string hasPassword = PasswordConverter.GetHashPassword(password);
            User user = CreateNewUser(username, hasPassword);
            _userRepository.Create(user);
            _userRepository.Save();
        }

        private User CreateNewUser(string username, string password)
        {
            User user = new()
            {
                Name = username,
                Password = password
            };
            return user;
        }

        public bool IsContainLogin(string login)
        {
            bool hasLoginName = _userRepository.GetAll()
                .Where(x => x.Name.Trim() == login)
                .Any();

            return hasLoginName;
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}
