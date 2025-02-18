using FinanceTracker.DAL;
using MyExtension;

namespace FinanceTracker.Domain.Service
{
    public class UserRegistrationService
    {
        private const int MIN_LEN_LOGIN = 4;
        private const int MIN_LEN_PASSWORD = 6;
        private const int MAX_LEN_PASSWORD = 20;

        private UserService _userService;

        private string _login;
        private string _password;
        private string _repeatPassword;

        public bool IsLoginWarning { get; private set; }
        public string LoginWarningMessage { get; private set; }
        public bool IsPasswordWarning { get; private set; }
        public string PasswordWarningMessage { get; private set; }
        public bool IsRepeatPasswordWarning { get; private set; }
        public string RepeatPasswordWarningMessage { get; private set; }

        public User User { get; private set; }

        public UserRegistrationService(string login, string password, string repeatPassword)
        {
            _login = login.Trim();
            _password = password.Trim();
            _repeatPassword = repeatPassword.Trim();
        }

        public void Inicializaton()
        {
            _userService = new();
        }

        public void Inicializaton(UserService userService)
        {
            _userService = userService;
        }

        public void Validate()
        {
            LoginValidation();
            PasswordValidation();
            RepeatPasswordValidation();
        }

        private void LoginValidation()
        {
            if (_login.IsNullOrWhiteSpace())
            {
                LoginWarningMessage = "Не заполнен";
                IsLoginWarning = true;
                return;
            }

            if (_login.Length < MIN_LEN_LOGIN || _login.Length > UserService.MAX_LEN_LOGIN)
            {
                LoginWarningMessage = $"Логин не должен быть меньше {MIN_LEN_LOGIN} и больше {UserService.MAX_LEN_LOGIN} символов";
                IsLoginWarning = true;
                return;
            }

            bool isContainLogin = _userService.IsContainLogin(_login);
            if (isContainLogin)
            {
                LoginWarningMessage = "Придумайте другой логин";
                IsLoginWarning = true;
                return;
            }

            LoginWarningMessage = string.Empty;
            IsLoginWarning = false;
        }

        private void PasswordValidation()
        {
            if (_password.IsNullOrWhiteSpace())
            {
                PasswordWarningMessage = "Не заполнен";
                IsPasswordWarning = true;
                return;
            }

            if (_password.Length < MIN_LEN_PASSWORD || _password.Length > MAX_LEN_PASSWORD)
            {
                PasswordWarningMessage = $"Пароль не должен быть меньше {MIN_LEN_PASSWORD} и больше {MAX_LEN_PASSWORD} символов";
                IsPasswordWarning = true;
                return;
            }

            PasswordWarningMessage = string.Empty;
            IsPasswordWarning = false;
        }

        private void RepeatPasswordValidation()
        {
            if (_repeatPassword.IsNullOrWhiteSpace())
            {
                RepeatPasswordWarningMessage = "Не заполнен";
                IsRepeatPasswordWarning = true;
                return;
            }

            if (_password.Trim() != _repeatPassword.Trim())
            {
                RepeatPasswordWarningMessage = "Повторный пароль не совпадает";
                IsRepeatPasswordWarning = true;
                return;
            }

            RepeatPasswordWarningMessage = string.Empty;
            IsRepeatPasswordWarning = false;
        }

        public bool IsAllCorrect()
        {
            return !IsLoginWarning && !IsPasswordWarning && !IsRepeatPasswordWarning;
        }

        public void CreateUser()
        {
            _userService.AddUser(_login, _password);
            User = _userService.GetUserLogin(_login);
        }
    }
}
