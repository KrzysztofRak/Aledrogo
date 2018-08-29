using Aledrogo.DTO;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    [Collection("Services")]
    public class UserRepositoryTest
    {
        private readonly ServicesFixture _services;

        public UserRepositoryTest(ServicesFixture services)
        {
            _services = services;
        }

        [Fact]
        public void RegistrationTest()
        {
            RegistrationDTO dto = new RegistrationDTO { UserName = "TestUser", Password = "Qwerty1234!", ConfirmPassword = "Qwerty1234!" };
            bool result = (_services.UserRepository.Register(dto, "User")).Result.Succeeded;
            Assert.True(result != true);
        }
    }
}
