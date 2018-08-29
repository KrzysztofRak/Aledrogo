using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests
{
    [Collection("Services Collection")]
    public class CategoryCacheTest
    {
        private readonly ICategoryCache _repo;
        public CategoryCacheTest()
        {
            var services = new ConfigureServices(new ServiceCollection()).Configure();
            var serviceProvider = services.BuildServiceProvider();
            _repo = serviceProvider.GetRequiredService<ICategoryCache>();
        }

        [Fact]
        public async void LoadFromDatabaseTest()
        {
            Assert.True(_repo.CategoryDTOs.Any());
        }
    }
}
