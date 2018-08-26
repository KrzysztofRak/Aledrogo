using Aledrogo.Data.DataToSeed;
using Aledrogo.Models;
using Aledrogo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    public class ProductRepositoryTest
    {
        [Fact]
        public async void GetAllFromCategory()
        {
            ProductRespository productsRepository = Services.Provider.GetRequiredService<ProductRespository>();
            ICollection<Product> products = await productsRepository.GetAllFromCategory(1);

            Assert.True(products.Count == 10);
        }
    }
}
