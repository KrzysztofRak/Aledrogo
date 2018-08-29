using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    public class UserRepositoryTest
    {
        private readonly IUserRepository _repo;
        public UserRepositoryTest()
        {
            var services = new ConfigureServices(new ServiceCollection()).Configure();
            var serviceProvider = services.BuildServiceProvider();
            _repo = serviceProvider.GetRequiredService<IUserRepository>();

        }
        [Fact]
        public void RegistrationTest()
        {
            RegistrationDTO dto = new RegistrationDTO { UserName = "TestUser", Password = "Qwerty1234!", ConfirmPassword = "Qwerty1234!" };
            bool result = (_repo.Registration(dto, "User")).Result.Succeeded;
            Assert.True(result != true);
        }
    }
}
