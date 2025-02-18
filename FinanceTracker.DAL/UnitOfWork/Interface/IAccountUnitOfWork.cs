using FinanceTracker.DAL.Repository.Interface;

namespace FinanceTracker.DAL.UnitOfWork.Interface
{
    public interface IAccountUnitOfWork : IDisposable
    {
        public IAccountRepository AccountRepository { get; }
        public ITypeAccountRepository TypeAccountRepository { get; }

        public void Save();
    }
}
