using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    [Collection("StartupCollection")]
    public class UserRepositoryTest
    {
        private readonly IUserRepository _userRepository;

        public UserRepositoryTest(StartupFixture startupFixture)
        {
            _userRepository = startupFixture.ServiceProvider.GetRequiredService<IUserRepository>();
        }

        [Fact]
        public void RegistrationTest()
        {
            RegistrationDTO dto = new RegistrationDTO { UserName = "TestUser", Password = "Qwerty1234!", ConfirmPassword = "Qwerty1234!" };
            bool result = (_userRepository.Register(dto, "User")).Result.Succeeded;
            Assert.True(result);
        }
    }
}
