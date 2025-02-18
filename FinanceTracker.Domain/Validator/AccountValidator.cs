using FinanceTracker.DAL;

namespace FinanceTracker.Domain.Validator
{
    public class AccountValidator
    {
        public const int MIN_LEN_ACCOUNT_NAME = 2;
        public const int MAX_LEN_ACCOUNT_NAME = 20;

        private Account _simpleAccount;

        public bool IsWarning { get; private set; }
        public string TextWarning { get; private set; }

        public AccountValidator(Account simpleAccount)
        {
            _simpleAccount = simpleAccount;
        }

        public void Validate()
        {
            if (_simpleAccount.Name.Length < MIN_LEN_ACCOUNT_NAME)
            {
                IsWarning = true;
                TextWarning = $"Название счета должно быть больше {MIN_LEN_ACCOUNT_NAME} символов!";
                return;
            }
            if (_simpleAccount.Name.Length > MAX_LEN_ACCOUNT_NAME)
            {
                IsWarning = true;
                TextWarning = $"Название счета должно быть меньше {MAX_LEN_ACCOUNT_NAME} символов!";
                return;
            }

            if (_simpleAccount.TypeId < 0)
            {
                IsWarning = true;
                TextWarning = $"Не верный тип счета!";
                return;
            }

            IsWarning = false;
            TextWarning = string.Empty;
        }
    }
}
