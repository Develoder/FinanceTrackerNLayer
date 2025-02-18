using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository.Interface;
using Moq;

namespace FinanceTracker.Test.Domain.UserRegistration_Test.UserFixture
{
    public class UserRepositoryFillingUserFixture
    {
        public IUserRepository UserRepository;

        public UserRepositoryFillingUserFixture()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Павел", Password = "123123" },
                new User { Id = 2, Name = "Владимир", Password = "123123" },
                new User { Id = 3, Name = "Дмитрий", Password = "123123" },
            };
            Mock<IUserRepository> mock = new();
            mock.Setup(x => x.GetAll()).Returns(users);

            UserRepository = mock.Object;
        }
    }
}
