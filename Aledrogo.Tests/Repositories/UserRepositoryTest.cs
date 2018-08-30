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

            dto = new RegistrationDTO { UserName = "", Password = "Qwerty1234!", ConfirmPassword = "Qwerty1234!" };
            result = (_userRepository.Register(dto, "User")).Result.Succeeded;
            Assert.True(result != true);

            dto = new RegistrationDTO { UserName = "", Password = "", ConfirmPassword = "" };
            result = (_userRepository.Register(dto, "User")).Result.Succeeded;
            Assert.True(result != true);

            dto = new RegistrationDTO { UserName = "TestUser2", Password = "Qrty1234?", ConfirmPassword = "Qwerty1234!" };
            result = (_userRepository.Register(dto, "User")).Result.Succeeded;
            Assert.True(result != true);
        }
        [Fact]
        public void ChangePasswordTest()
        {
            PasswordDTO dto = new PasswordDTO { UserName = "test3@wp.pl", OldPassword = "zaqWSX123!", NewPassword = "Zxcvb1234!" };
            bool result = (_userRepository.ChangePassword(dto)).Result.Succeeded;
            Assert.True(result);

            dto = new PasswordDTO { UserName = "test3@wp.pl", OldPassword = "xcvb1234!", NewPassword = "" };
            result = (_userRepository.ChangePassword(dto)).Result.Succeeded;
            Assert.True(result != true);

            dto = new PasswordDTO { UserName = "", OldPassword = "xcvb1234!", NewPassword = "Zxcvb1234!" };
            result = (_userRepository.ChangePassword(dto)).Result.Succeeded;
            Assert.True(result != true);

            dto = new PasswordDTO { UserName = "test3@wp.pl", OldPassword = "", NewPassword = "Zxcvb1234!" };
            result = (_userRepository.ChangePassword(dto)).Result.Succeeded;
            Assert.True(result != true);
        }
        [Fact]
        public void GetAllTest()
        {
            int result = (_userRepository.GetAll()).Result.Count;
            Assert.True(result == 6);
        }

        [Fact]
        public void GetAllByNameTest()
        {
            int result = (_userRepository.GetAllByName("test")).Result.Count;
            Assert.True(result == 3);
        }
        
    }
}
