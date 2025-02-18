using FinanceTracker.DAL;
using FinanceTracker.DAL.UnitOfWork;
using FinanceTracker.DAL.UnitOfWork.Interface;

namespace FinanceTracker.Domain.Service
{
    public class AccountService : IDisposable
    {
        private readonly IAccountUnitOfWork _accountUnitOfWork;

        public AccountService()
        {
            _accountUnitOfWork = new AccountUnitOfWork();
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = _accountUnitOfWork.AccountRepository.GetAll().ToList();
            return accounts;
        }

        public List<Account> GetAccountsByUserId(int userId)
        {
            List<Account> accounts = _accountUnitOfWork.AccountRepository.GetAccountsByUserId(userId).ToList();
            return accounts;
        }

        public List<TypeAccount> GetTypeAccounts()
        {
            List<TypeAccount> typeAccounts = _accountUnitOfWork.TypeAccountRepository.GetAll().ToList();
            return typeAccounts;
        }

        public Account GetAccount(int id)
        {
            return _accountUnitOfWork.AccountRepository.Get(id);
        }

        public void AddAccount(Account account)
        {
            ClearAccount(account);

            _accountUnitOfWork.AccountRepository.Create(account);
            _accountUnitOfWork.Save();
        }

        public void UpdateAccount(Account account)
        {
            ClearAccount(account);

            _accountUnitOfWork.AccountRepository.Update(account);
            _accountUnitOfWork.Save();
        }

        private static void ClearAccount(Account account)
        {
            account.User = null;
            account.Transaction = null;
            account.Type = null; 
        }

        public void DeleteAccount(int accountId)
        {
            _accountUnitOfWork.AccountRepository.Delete(accountId);
            _accountUnitOfWork.Save();
        }

        public void Dispose()
        {
            _accountUnitOfWork.Dispose();
        }
    }
}
