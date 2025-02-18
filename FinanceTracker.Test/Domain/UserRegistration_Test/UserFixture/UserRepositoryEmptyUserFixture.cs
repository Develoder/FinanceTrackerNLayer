using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository.Interface;
using Moq;

namespace FinanceTracker.Test.Domain.UserRegistration_Test.UserFixture
{
    public class UserRepositoryEmptyUserFixture
    {
        public IUserRepository UserRepository;

        public UserRepositoryEmptyUserFixture()
        {
            Mock<IUserRepository> mock = new();
            mock.Setup(x => x.GetAll())
                .Returns(Enumerable.Empty<User>());

            UserRepository = mock.Object;
        }
    }
}
