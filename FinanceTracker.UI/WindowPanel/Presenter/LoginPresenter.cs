using FinanceTracker.DAL;
using FinanceTracker.Service.Interface;
using FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.Presenter
{
    public class LoginPresenter : IWindowPanel
    {
        private ILoginView _loginView;
        private UserService _userService;
        private IAuthService _authService;

        private List<User> _users;

        public event EventHandler<CreatorWindowPanel> SetNewWindow;

        public LoginPresenter(ILoginView loginView, UserService userService, IAuthService authService)
        {
            _loginView = loginView;
            _userService = userService;
            _authService = authService;

            _loginView.RegistrationRequested += OpenRegistration;
            _loginView.LoginAttempted += LoginAttempted;

            Initialize();
        }

        private void Initialize()
        {
            _users = _userService.GetAllUser();
            string[] nameUsers = _users.Select(x => x.Name.Trim()).ToArray();
            _loginView.FillUser(nameUsers);

            _loginView.ClearWarningLogin();
            _loginView.ClearWarningPassword();

            bool isLogin = _authService.IsLogin();
            if (isLogin)
            {
                int userId = _authService.GetLastLogin();
                int userIndex = _users.FindIndex(x => x.Id == userId);
                if (userIndex > -1)
                {
                    _loginView.UserIndex = userIndex;
                    return;
                }
            }

            _loginView.UserIndex = 0;
        }

        private void LoginAttempted(object? sender, EventArgs e)
        {
            Login();
        }

        public void PressEnter()
        {
            Login();
        }

        private void Login()
        {
            int selectedUserIndex = _loginView.UserIndex;

            if (selectedUserIndex < 0 && selectedUserIndex > _users.Count)
            {
                _loginView.SetWarningLogin("Не выбран пользователь");
                return;
            }
            _loginView.ClearWarningLogin();

            User selectUser = _users[selectedUserIndex];

            string password = _loginView.Password;
            bool isCorrectPassword = _userService.IsCorrectUserPassword(password.Trim(), selectUser.Password.Trim());

            if (!isCorrectPassword)
            {
                _loginView.SetWarningPassword("Не верный пароль");
                return;
            }
            _loginView.ClearWarningPassword();
            
            _authService.SaveLogin(selectUser.Id);
            Session.CurrentUser = selectUser;
            OpenManiMenu();
        }

        private void OpenManiMenu()
        {
            Dispose();
            SetNewWindow.Invoke(this, new ManiMenuCreatorWindowPanel());
        }

        private void OpenRegistration(object? sender, EventArgs e)
        {
            Dispose();
            SetNewWindow.Invoke(this, new RegistrationCreatorWindowPanel());
        }

        private void Dispose()
        {
            _userService.Dispose();
        }

        public Control GetControl()
        {
            return (Control)_loginView;
        }
    }
}
