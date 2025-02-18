namespace FinanceTracker.Service.Interface
{
    public interface IAuthService
    {
        public bool IsLogin();
        public int GetLastLogin();
        public void SaveLogin(int userId);
    }
}
