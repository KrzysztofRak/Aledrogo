using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests
{
    public class CategoryCacheTest
    {
        private readonly CategoryCache _categoryCache;

        public CategoryCacheTest()
        {
            _categoryCache = Services.Provider.GetRequiredService<CategoryCache>();
        }

        [Fact]
        public async void LoadFromDatabaseTest()
        {
            Assert.True(_categoryCache.CategoryDTOs.Any());
        }
    }
}
