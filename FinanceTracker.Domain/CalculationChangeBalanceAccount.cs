namespace FinanceTracker.Domain
{
    public class CalculationChangeBalanceAccount
    {
        private bool _isUpdate;

        private bool _isIncome;
        private decimal _amount;

        private bool _isIncomeNew;
        private decimal _amountNew;

        public CalculationChangeBalanceAccount(bool isIncome, decimal amount)
        {
            _isIncome = isIncome;
            _amount = amount;
            _isUpdate = false;
        }

        public void SetUpdatedTransaction(bool isIncomeNew, decimal amountNew)
        {
            _isIncomeNew = isIncomeNew;
            _amountNew = amountNew;
            _isUpdate = true;
        }

        public decimal GetAmountDifference()
        {
            return _isUpdate ? GetEditeAmountDifference() : GetNewAmountDifference();
        }

        private decimal GetNewAmountDifference()
        {
            return _isIncome ? _amount : -_amount;
        }

        private decimal GetEditeAmountDifference()
        {
            decimal refundAmount = -GetNewAmountDifference();
            decimal addNewAmount = _isIncomeNew ? _amountNew : -_amountNew;
            decimal returnAmount = refundAmount + addNewAmount;

            return returnAmount;
        }
    }
}