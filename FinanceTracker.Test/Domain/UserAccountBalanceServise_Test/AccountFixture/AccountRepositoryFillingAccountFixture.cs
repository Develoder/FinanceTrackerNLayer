using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository.Interface;
using Moq;

namespace FinanceTracker.Test.Domain.UserAccountBalanceService_Test.AccountFixture
{
    public class AccountRepositoryFillingAccountFixture
    {
        public IAccountRepository AccountRepository { get; private set; }

        public AccountRepositoryFillingAccountFixture()
        {
            Mock<IAccountRepository> mock = new();
            List<Account> accounts = new List<Account>
                {
                    new Account { UserId = 1, Balance = 40 },
                    new Account { UserId = 1, Balance = 54 }
                };
            mock.Setup(x => x.GetAll()).Returns(accounts);
            mock.Setup(x => x.GetAccountsByUserId(1)).Returns(accounts);

            AccountRepository = mock.Object;
        }
    }
}
