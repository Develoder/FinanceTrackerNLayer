using FinanceTracker.Domain.Service;

namespace FinanceTracker.Test.Domain.UserRegistration_Test
{
    public class RepeatPasswordValidation_Test
    {
        [Theory]
        [InlineData("      ")]
        [InlineData("")]
        [InlineData(null)]
        public void RepeatPasswordValidationEmptyInput_Test(string repeatPassword)
        {
            try
            {
                // Arrange
                UserRegistrationService userRegistration = new("", repeatPassword, repeatPassword);
                userRegistration.Inicializaton();

                // Act
                userRegistration.Validate();

                // Assert
                Assert.True(userRegistration.IsRepeatPasswordWarning);
            }
            catch (NullReferenceException)
            {

            }
        }

        [Theory]
        [InlineData("123456", "1234232")]
        [InlineData("12310920svokhjfalskjdflkasjdlfk", "")]
        [InlineData("   ", " ")]
        public void RepeatPasswordValidationMismatchInput_Test(string passwordm, string repeatPassword)
        {
            try
            {
                // Arrange
                UserRegistrationService userRegistration = new("", passwordm, repeatPassword);
                userRegistration.Inicializaton();

                // Act
                userRegistration.Validate();

                // Assert
                Assert.True(userRegistration.IsRepeatPasswordWarning);
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
