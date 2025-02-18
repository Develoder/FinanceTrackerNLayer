using FinanceTracker.Domain.Service;

namespace FinanceTracker.Test.Domain.UserRegistration_Test
{
    public class PasswordValidation_Test
    {
        [Theory]
        [InlineData("      ")]
        [InlineData("")]
        [InlineData(null)]
        public void PasswordValidationEmptyInput_Test(string password)
        {
            try
            {
                // Arrange
                UserRegistrationService userRegistration = new("", password, "");
                userRegistration.Inicializaton();

                // Act
                userRegistration.Validate();

                // Assert
                Assert.True(userRegistration.IsPasswordWarning);
            }
            catch (NullReferenceException)
            {

            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void PasswordValidationMinLength_Test(int countChar)
        {
            // Arrange
            string password = string.Join("", Enumerable.Repeat("1", countChar));
            UserRegistrationService userRegistration = new("", password, "");
            userRegistration.Inicializaton();

            // Act
            userRegistration.Validate();

            // Assert
            Assert.True(userRegistration.IsPasswordWarning);
        }

        [Theory]
        [InlineData(21)]
        [InlineData(100)]
        public void PasswordValidationMaxLength_Test(int countChar)
        {
            // Arrange
            string password = string.Join("", Enumerable.Repeat("1", countChar));
            UserRegistrationService userRegistration = new("", password, "");
            userRegistration.Inicializaton();

            // Act
            userRegistration.Validate();

            // Assert
            Assert.True(userRegistration.IsPasswordWarning);
        }
    }
}
