using FinanceTracker.DAL;
using FinanceTracker.DAL.Repository;
using FinanceTracker.DAL.Repository.Interface;

namespace FinanceTracker.Domain.Service
{
    public class UserAccountBalanceService : IDisposable
    {
        private readonly IAccountRepository _accountRepository;
        private User _currentUser;

        private List<Account> _accounts;

        public bool IsHasAccount { get; private set; }
        public decimal Balance { get; private set; }

        public UserAccountBalanceService()
        {
            _accountRepository = new AccountRepository(new EntitiesContext());
        }

        public UserAccountBalanceService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void SetUser(User user)
        {
            _currentUser = user;
        }

        public void UpdateInformationBalanced()
        {
            LoadAccount();
            UpdateIsHasAccount();
            if (IsHasAccount)
                UpdateBalance();
        }

        private void LoadAccount()
        {
            _accounts = _accountRepository
                .GetAccountsByUserId(_currentUser.Id)
                .ToList();
        }

        private void UpdateIsHasAccount()
        {
            IsHasAccount = _accounts != null && _accounts.Count != 0;
        }

        private void UpdateBalance()
        {
            Balance = _accounts.Sum(x => x.Balance);
        }

        public void Dispose()
        {
            _accountRepository.Dispose();
        }
    }
}
