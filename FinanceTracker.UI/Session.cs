using FinanceTracker.DAL;

namespace FinanceTracker.UI
{
    public static class Session
    {
        private static User _currentUser;
        public static User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                OnUserChanged();
            }
        }

        public static event Action UserChanged;

        private static void OnUserChanged()
        {
            UserChanged?.Invoke();
        }
    }
}
