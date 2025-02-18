using FinanceTracker.DAL;
using FinanceTracker.Test.Domain.UserAccountBalanceService_Test.AccountFixture;
using FinanceTracker.DAL.Repository.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.Test.Domain.UserAccountBalanceService_Test
{
    public class UserAccountBalance_Test : IClassFixture<AccountRepositoryEmptyAccountFixture>, IClassFixture<AccountRepositoryFillingAccountFixture>
    {
        private AccountRepositoryEmptyAccountFixture _accountRepositoryEmptyAccountFixture;
        private AccountRepositoryFillingAccountFixture _accountRepositoryFillingAccountFixture;
        public UserAccountBalance_Test(AccountRepositoryEmptyAccountFixture accountRepositoryEmptyAccountFixture, AccountRepositoryFillingAccountFixture accountFillingAccountFixture)
        {
            _accountRepositoryEmptyAccountFixture = accountRepositoryEmptyAccountFixture;
            _accountRepositoryFillingAccountFixture = accountFillingAccountFixture;
        }

        [Fact]
        public void EmptyAccountBalance_Test()
        {
            // Arrange
            IAccountRepository accountRepository = _accountRepositoryEmptyAccountFixture.AccountRepository;
            UserAccountBalanceService userAccountBalanceService = new(accountRepository);
            User user = new() { Id = 1 };
            userAccountBalanceService.SetUser(user);

            // Act
            userAccountBalanceService.UpdateInformationBalanced();

            // Assert
            Assert.False(userAccountBalanceService.IsHasAccount);
        }

        [Fact]
        public void AmountAccountBalance_Test()
        {
            // Arrange
            IAccountRepository accountRepository = _accountRepositoryFillingAccountFixture.AccountRepository;
            UserAccountBalanceService userAccountBalanceService = new(accountRepository);
            User user = new() { Id = 1 };
            userAccountBalanceService.SetUser(user);

            // Act
            userAccountBalanceService.UpdateInformationBalanced();

            // Assert
            Assert.Equal(userAccountBalanceService.Balance, 40 + 54);
        }
    }
}
