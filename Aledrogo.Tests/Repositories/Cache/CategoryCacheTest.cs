using System.Linq;
using Xunit;

namespace Aledrogo.Tests
{
    [Collection("Services")]
    public class CategoryCacheTest
    {
        private readonly ServicesFixture _services;

        public CategoryCacheTest(ServicesFixture services)
        {
            _services = services;
        }

        [Fact]
        public async void LoadFromDatabaseTest()
        {
            var concernedCategoriesIds = _services.CategoryCache.GetConcernedCategoriesIds(1);

            Assert.True(concernedCategoriesIds.Any());
        }
    }
}
