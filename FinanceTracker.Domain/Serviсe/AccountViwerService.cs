using FinanceTracker.DAL;
using FinanceTracker.Domain.DTO;

namespace FinanceTracker.Domain.Service
{
    public class AccountViewerService : IDisposable
    {
        private AccountService _accountService;

        private int _userId;
        private List<Account> _accounts;
        private List<TypeAccount> _typeAccounts;

        public AccountViewerService()
        {
            _accountService = new AccountService();
        }

        public AccountViewerService(AccountService accountService)
        {
            _accountService = accountService;
        }

        public void SetUserId(int userId)
        {
            _userId = userId;
        }

        public void LoadData()
        {
            _accounts = _accountService.GetAccountsByUserId(_userId);
            _typeAccounts = _accountService.GetTypeAccounts();
        }

        public bool AnyAccount()
        {
            return _accounts.Any();
        }

        public List<AccountViewerData> GetAllAccountViewerData()
        {
            List<AccountViewerData> accountViewersData = new();
            foreach (Account account in _accounts)
            {
                TypeAccount foundTypeAccount = _typeAccounts.First(x => x.Id == account.TypeId);
                account.Type = foundTypeAccount;

                var accountViewerData = AccountViewerData.Map(account);
                accountViewersData.Add(accountViewerData);
            }

            return accountViewersData;
        }

        public void Dispose()
        {
            _accountService.Dispose();
        }
    }
}
