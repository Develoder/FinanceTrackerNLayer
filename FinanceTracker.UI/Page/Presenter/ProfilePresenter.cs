using FinanceTracker.UI.Page.Interface;

namespace FinanceTracker.UI.Page.Presenter
{
    public class ProfilePresenter : IPage
    {
        private IProfileView _profileView;

        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public ProfilePresenter(IProfileView profileView)
        {
            _profileView = profileView;

            _profileView.Close += MakeLogout;

            Initialize();
        }

        private void Initialize()
        {
            _profileView.SetUsername(Session.CurrentUser.Name);
        }

        private void MakeLogout(object? sender, EventArgs e)
        {
            MakeLogout();
        }

        public void PressEnter()
        {
            MakeLogout();
        }

        private void MakeLogout()
        {
            Logout.Invoke(this, EventArgs.Empty);
        }

        public string GetHeader()
        {
            return "Профиль";
        }

        public Control GetControl()
        {
            return (Control)_profileView;
        }

        public void Close()
        {
            
        }
    }
}
