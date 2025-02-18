using FinanceTracker.DAL;
using FinanceTracker.Service.Interface;
using FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.Presenter
{
    public class RegistrationPresenter : IWindowPanel
    {
        private IRegistrationView _registrationView;
        private UserService _userService;
        private UserRegistrationService _userRegistration;
        private IAuthService _authService;

        private User _newRegisteredUser;

        public event EventHandler<CreatorWindowPanel> SetNewWindow;

        public RegistrationPresenter(IRegistrationView registrationView, UserService userService, IAuthService authService)
        {
            _registrationView = registrationView;
            _userService = userService;
            _authService = authService;

            _registrationView.LoginLeave += LoginLeave;
            _registrationView.PasswordChanged += PasswordChanged;
            _registrationView.RepeatPasswordChanged += RepeatPasswordChanged;
            _registrationView.MakeRegistration += MakeRegistration;
            _registrationView.ReturnLoginWindow += ReturnLoginWindow;

            Initialize();
        }

        private void Initialize()
        {
            _registrationView.ClearWarningLogin();
            _registrationView.ClearWarningPassword();
            _registrationView.ClearWarningRepeatPassword();
        }

        private void MakeRegistration(object? sender, EventArgs e)
        {
            Registration();
        }

        public void PressEnter()
        {
            Registration();
        }

        private void Registration()
        {
            ValidateAndShowWarningMessage();
            if (_userRegistration.IsAllCorrect())
            {
                CreateUser();
                SaveLoginParametr();
                ReturnToLogin();
            }
        }

        private void LoginLeave(object? sender, EventArgs e)
        {
            ValidateAndShowWarningMessage();
        }

        private void PasswordChanged(object? sender, EventArgs e)
        {
            ValidateAndShowWarningMessage();
        }

        private void RepeatPasswordChanged(object? sender, EventArgs e)
        {
            ValidateAndShowWarningMessage();
        }

        private void ValidateAndShowWarningMessage()
        {
            ValidateInput();
            ShowWarningMessage();
        }

        private void ValidateInput()
        {
            string login = _registrationView.Login;
            string password = _registrationView.Password;
            string repeatPassword = _registrationView.RepeatPassword;

            _userRegistration = new(login, password, repeatPassword);
            _userRegistration.Inicializaton(_userService);
            _userRegistration.Validate();
        }

        private void ShowWarningMessage()
        {
            if (_userRegistration.IsLoginWarning)
                _registrationView.SetWarningLogin(_userRegistration.LoginWarningMessage);
            else
                _registrationView.ClearWarningLogin();

            if (_userRegistration.IsPasswordWarning)
                _registrationView.SetWarningPassword(_userRegistration.PasswordWarningMessage);
            else
                _registrationView.ClearWarningPassword();

            if (_userRegistration.IsRepeatPasswordWarning)
                _registrationView.SetWarningRepeatPassword(_userRegistration.RepeatPasswordWarningMessage);
            else
                _registrationView.ClearWarningRepeatPassword();
        }

        private void CreateUser()
        {
            _userRegistration.CreateUser();
            _newRegisteredUser = _userRegistration.User;
        }

        private void SaveLoginParametr()
        {
            _authService.SaveLogin(_newRegisteredUser.Id);
        }

        private void ReturnLoginWindow(object? sender, EventArgs e)
        {
            ReturnToLogin();
        }

        private void ReturnToLogin()
        {
            Dispose();
            SetNewWindow.Invoke(this, new LoginCreatorWindowPanel());
        }

        private void Dispose()
        {
            _userService.Dispose();
        }

        public Control GetControl()
        {
            return (Control)_registrationView;
        }
    }
}
