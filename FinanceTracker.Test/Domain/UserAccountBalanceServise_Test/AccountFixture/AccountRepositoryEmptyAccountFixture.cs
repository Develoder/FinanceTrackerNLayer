using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository.Interface;
using Moq;

namespace FinanceTracker.Test.Domain.UserAccountBalanceService_Test.AccountFixture
{
    public class AccountRepositoryEmptyAccountFixture
    {
        public IAccountRepository AccountRepository { get; private set; }

        public AccountRepositoryEmptyAccountFixture()
        {
            Mock<IAccountRepository> mock = new();
            mock.Setup(x => x.GetAll())
                .Returns(Enumerable.Empty<Account>());

            AccountRepository = mock.Object;
        }
    }
}
