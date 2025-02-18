using FinanceTracker.Test.Domain.UserRegistration_Test.UserFixture;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.Test.Domain.UserRegistration_Test
{
    public class LoginValidation_Test : IClassFixture<UserRepositoryEmptyUserFixture>, IClassFixture<UserRepositoryFillingUserFixture>
    {
        private UserRepositoryEmptyUserFixture _userRepositoryEmptyUserFixture;
        private UserRepositoryFillingUserFixture _userRepositoryFillingUserFixture;

        public LoginValidation_Test(UserRepositoryEmptyUserFixture userRepositoryEmptyUserFixture, UserRepositoryFillingUserFixture userRepositoryFillingUserFixture)
        {
            _userRepositoryEmptyUserFixture = userRepositoryEmptyUserFixture;
            _userRepositoryFillingUserFixture = userRepositoryFillingUserFixture;
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void LoginValidationEmptyInput_Test(string username)
        {
            try
            {
                // Arrange
                UserRegistrationService userRegistration = new(username, "", "");
                UserService userService = new(_userRepositoryEmptyUserFixture.UserRepository);
                userRegistration.Inicializaton(userService);

                // Act
                userRegistration.Validate();

                // Assert
                Assert.True(userRegistration.IsLoginWarning);
            }
            catch (NullReferenceException)
            {

            }
        }

        [Theory]
        [InlineData("Юля")]
        [InlineData("Юра")]
        [InlineData("Як")]
        [InlineData("Ден")]
        public void LoginValidationMinLength_Test(string username)
        {
            // Arrange
            UserRegistrationService userRegistration = new(username, "", "");
            UserService userService = new(_userRepositoryEmptyUserFixture.UserRepository);
            userRegistration.Inicializaton(userService);

            // Act
            userRegistration.Validate();

            // Assert
            Assert.True(userRegistration.IsLoginWarning);
        }


        [Theory]
        [InlineData("51654654654654654654654654654654")]
        [InlineData("Екатерина Екатерина Екатерина")]
        [InlineData("Куризьябова Екатерина Даниилован")]
        public void LoginValidationMaxLength_Test(string username)
        {
            // Arrange
            UserRegistrationService userRegistration = new(username, "", "");
            UserService userService = new(_userRepositoryEmptyUserFixture.UserRepository);
            userRegistration.Inicializaton(userService);

            // Act
            userRegistration.Validate();

            // Assert
            Assert.True(userRegistration.IsLoginWarning);
        }

        [Fact]
        public void LoginValidationContainLogin_Test()
        {
            // Arrange
            UserRegistrationService userRegistration = new("Владимир", "", "");
            UserService userService = new(_userRepositoryFillingUserFixture.UserRepository);
            userRegistration.Inicializaton(userService);

            // Act
            userRegistration.Validate();

            // Assert
            Assert.True(userRegistration.IsLoginWarning);
        }
    }
}
