using FinanceTracker.DAL.Repository.Interface;

namespace FinanceTracker.DAL.UnitOfWork.Interface
{
    public interface ITransactionUnitOfWork : IDisposable
    {
        public IAccountRepository AccountRepository { get; }
        public ICategoryTransactionRepository CategoryTransactionRepository { get; }
        public ITransactionRepository TransactionRepository { get; }

        public void Save();
    }
}
