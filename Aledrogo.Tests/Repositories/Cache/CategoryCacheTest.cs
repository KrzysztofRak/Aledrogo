using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests
{
    [Collection("StartupCollection")]
    public class CategoryCacheTest
    {
        private readonly ICategoryCache _categoryCache;

        public CategoryCacheTest(StartupFixture startupFixture)
        {
            _categoryCache = startupFixture.ServiceProvider.GetRequiredService<ICategoryCache>();
        }

        [Fact]
        public async void LoadFromDatabaseTest()
        {
            var concernedCategoriesIds = _categoryCache.GetConcernedCategoriesIds(1);

            Assert.True(concernedCategoriesIds.Any());
        }
    }
}
