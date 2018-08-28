using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests
{
    [Collection("Services Collection")]
    public class CategoryCacheTest
    {
        private readonly ServicesFixture _servicesFixture;

        public CategoryCacheTest(ServicesFixture servicesFixture)
        {
            _servicesFixture = servicesFixture;
        }

        [Fact]
        public async void LoadFromDatabaseTest()
        {
            Assert.True(_servicesFixture.CategoryCache.CategoryDTOs.Any());
        }
    }
}
