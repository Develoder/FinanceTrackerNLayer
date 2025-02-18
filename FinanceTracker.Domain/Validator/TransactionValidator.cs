using FinanceTracker.DAL;

namespace FinanceTracker.Domain.Validator
{
    public class TransactionValidator
    {
        public const int MAX_LEN_DESCRIPTION = 100;

        private Transaction _simpleTransaction;

        public string TextWarning { get; private set; }
        public bool IsWarning { get; private set; }

        public TransactionValidator(Transaction simpleTransaction)
        {
            _simpleTransaction = simpleTransaction;
        }

        public void Validate()
        {
            if (_simpleTransaction.Amount < 0)
            {
                TextWarning = "Сумма не может быть меньше нуля!";
                IsWarning = true;
                return;
            }

            if (_simpleTransaction.CategoryId < 0)
            {
                TextWarning = "Не корректная категория!";
                IsWarning = true;
                return;
            }

            if (_simpleTransaction.AccountId < 0)
            {
                TextWarning = "Не корректный счет!";
                IsWarning = true;
                return;
            }

            if (_simpleTransaction.Description.Length > MAX_LEN_DESCRIPTION)
            {
                TextWarning = $"Описатние не должно привышать {MAX_LEN_DESCRIPTION} символов!";
                IsWarning = true;
                return;
            }
        }
    }
}
