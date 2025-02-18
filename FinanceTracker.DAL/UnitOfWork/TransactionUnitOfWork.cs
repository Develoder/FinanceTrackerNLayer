using FinanceTracker.DAL.Repository;
using FinanceTracker.DAL.Repository.Interface;
using FinanceTracker.DAL.UnitOfWork.Interface;
using Microsoft.EntityFrameworkCore.Storage;

namespace FinanceTracker.DAL.UnitOfWork
{
    public class TransactionUnitOfWork : ITransactionUnitOfWork
    {
        private EntitiesContext _entitiesContext;
        private IDbContextTransaction _transaction;

        private IAccountRepository _accountRepository;
        private ICategoryTransactionRepository _categoryTransactionRepository;
        private ITransactionRepository _transactionRepository;

        public TransactionUnitOfWork()
        {
            _entitiesContext = new();
            _transaction = _entitiesContext.Database.BeginTransaction();
        }

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

        public ICategoryTransactionRepository CategoryTransactionRepository
        {
            get
            {
                if (_categoryTransactionRepository == null)
                {
                    _categoryTransactionRepository = new CategoryTransactionRepository(_entitiesContext);
                }
                return _categoryTransactionRepository;
            }
        }

        public ITransactionRepository TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(_entitiesContext);
                }
                return _transactionRepository;
            }
        }

        public void Save()
        {
            try
            {
                _entitiesContext.SaveChanges();
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
            _entitiesContext.SaveChanges();
        }

        public void Dispose()
        {
            _entitiesContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
