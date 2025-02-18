using FinanceTracker.DAL.Repository;
using FinanceTracker.DAL.Repository.Interface;
using FinanceTracker.DAL.UnitOfWork.Interface;

namespace FinanceTracker.DAL.UnitOfWork
{
    public class AccountUnitOfWork : IAccountUnitOfWork
    {
        private EntitiesContext _entitiesContext = new();
        private IAccountRepository _accountRepository;
        private ITypeAccountRepository _typeAccountRepository;

        public IAccountRepository AccountRepository
        {
            get
            {
                if (_accountRepository == null)
                {
                    _accountRepository = new AccountRepository(_entitiesContext);
                }
                return _accountRepository;
            }
        }

        public ITypeAccountRepository TypeAccountRepository
        {
            get
            {
                if (_typeAccountRepository == null)
                {
                    _typeAccountRepository = new TypeAccountRepository(_entitiesContext);
                }
                return _typeAccountRepository;
            }
        }

        public void Save()
        {
            _entitiesContext.SaveChanges();
        }

        public void Dispose()
        {
            _entitiesContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
