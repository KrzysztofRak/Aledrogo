using Aledrogo.DTO;
using Aledrogo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    [Collection("StartupCollection")]
    public class AddressRespositoryTest 
    {
        private readonly IAddressRespository _addressRespository;

        public AddressRespositoryTest(StartupFixture startupFixture)
        {
            _addressRespository = startupFixture.ServiceProvider.GetRequiredService<IAddressRespository>();
        }

        [Fact]
        public void GetAllUserAddressesTest()
        {
            bool result = _addressRespository.GetAllUserAddresses("test2@wp.pl").Result.Count == 1;
            Assert.True(result);


            result = _addressRespository.GetAllUserAddresses("test").Result == null;
            Assert.True(result);
        }
        [Fact]
        public void AddAddressTest()
        {
            AddressDTO dto = new AddressDTO
            {
                UserName = "test3@wp.pl",
                City = "test",
                StreetAddress = "test",
                Country = "test",
                PostCode = "27-456",
                FullName = "test test",
                PhoneNumber = "567890987"
            };
            bool result = _addressRespository.AddAddress(dto).Result;
            Assert.True(result);

            dto.UserName = "cos";
            result = _addressRespository.AddAddress(dto).Result;
            Assert.True(result != true);
        }
    }
}
