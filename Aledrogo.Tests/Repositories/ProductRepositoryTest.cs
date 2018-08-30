using Aledrogo.Data.DataToSeed;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    [Collection("StartupCollection")]
    public class ProductRepositoryTest
    {
        private readonly IProductRepository _productRepository;

        public ProductRepositoryTest(StartupFixture startupFixture)
        {
            _productRepository = startupFixture.ServiceProvider.GetRequiredService<IProductRepository>();
        }

        [Fact]
        public async void GetAllFromCategoryTest()
        {
            ICollection<Product> products = await _productRepository.GetAllFromCategory(1);

            Assert.True(products.Count == 10);
        }

        [Fact]
        public async void GetByFilterTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.SearchString = "Redmi Note";
            productFilter.MinPrice = 200;
            productFilter.MaxPrice = 0;
            productFilter.CategoryId = 2;

            productFilter.TypeOfOffer = TypeOfOffer.AUCTION | TypeOfOffer.BUY_IT_NOW | TypeOfOffer.ADVERTISEMENT;

            productFilter.ProductStateIds.Add(ProductStateSeed.uzywany.Id);
            productFilter.ProductStateIds.Add(ProductStateSeed.powystawowy.Id);
            productFilter.ProductStateIds.Add(ProductStateSeed.uszkodzony.Id);

            productFilter.DeliveryMethodTypeIds.Add(DeliveryMethodTypeSeed.kurier.Id);
            productFilter.DeliveryMethodTypeIds.Add(DeliveryMethodTypeSeed.list.Id);
            productFilter.DeliveryMethodTypeIds.Add(DeliveryMethodTypeSeed.odbior_osobisty.Id);
            productFilter.DeliveryMethodTypeIds.Add(DeliveryMethodTypeSeed.paczkomat.Id);

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter, 1, 1);

            Assert.True(products.Count == 1, products.Count().ToString());
        }
    }
}
