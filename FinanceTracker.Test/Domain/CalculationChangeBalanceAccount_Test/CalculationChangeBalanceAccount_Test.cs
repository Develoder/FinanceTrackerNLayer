using FinanceTracker.Domain;

namespace FinanceTracker.Test.Domain.CalculationChangeBalanceAccount_Test
{
    public class CalculationChangeBalanceAccount_Test
    {
        [Theory]
        [InlineData(true, 100, 100)]
        [InlineData(false, 100, -100)]
        [InlineData(true, 0, 0)]
        public void NewCalculationChangeBalanceAccount_Test(bool isIncome, decimal amount, decimal trueAmount)
        {
            // Arrange
            CalculationChangeBalanceAccount calculationChangeBalanceAccount = new(isIncome, amount);
            decimal verifibleAmount;

            // Act
            verifibleAmount = calculationChangeBalanceAccount.GetAmountDifference();

            // Assert
            Assert.Equal(trueAmount, verifibleAmount);
        }

        [Theory]
        [InlineData(true, 100, true, 200, 100)]
        [InlineData(true, 50, false, 150, -200)]
        [InlineData(false, 1000, true, 200, 1200)]
        [InlineData(false, 10, false, 20, -10)]
        [InlineData(false, 0, false, 0, 0)]
        public void UpdateCalculationChangeBalanceAccount_Test(bool isIncome, decimal amount, bool isIncomeNew, decimal amountNew, decimal trueAmount)
        {
            // Arrange
            CalculationChangeBalanceAccount calculationChangeBalanceAccount = new(isIncome, amount);
            calculationChangeBalanceAccount.SetUpdatedTransaction(isIncomeNew, amountNew);
            decimal verifibleAmount;

            // Act
            verifibleAmount = calculationChangeBalanceAccount.GetAmountDifference();

            // Assert
            Assert.Equal(trueAmount, verifibleAmount);
        }
    }
}
