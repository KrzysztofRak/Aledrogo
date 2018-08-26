using Aledrogo.Repositories.Cache;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Aledrogo.Tests
{
    public class CategoryCacheTest
    {
        [Fact]
        public void Load()
        {
            CategoryCache categoryCache = Services.Provider.GetRequiredService<CategoryCache>();

            Assert.True(categoryCache.CategoryDTOs.Count > 0);
        }
    }
}
