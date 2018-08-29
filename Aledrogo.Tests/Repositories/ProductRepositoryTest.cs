using Aledrogo.ModelFilters;
using Aledrogo.Models;
using Aledrogo.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Aledrogo.Tests.Repositories
{
    [Collection("Services")]
    public class ProductRepositoryTest
    {
        private readonly ServicesFixture _services;

        public ProductRepositoryTest(ServicesFixture services)
        {
            _services = services;
        }

        [Fact]
        public async void GetAllFromCategoryTest()
        {
            ICollection<Product> products = await _services.ProductRepository.GetAllFromCategory(1);

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
            productFilter.ProductStates.Add(ProductState.SECONDHAND);
            productFilter.ProductStates.Add(ProductState.DAMAGED);
            productFilter.ProductStates.Add(ProductState.AFTER_EXHIBITION);

            productFilter.TypesOfOffers.Add(TypeOfOffer.AUCTION | TypeOfOffer.BUY_IT_NOW);
            productFilter.TypesOfOffers.Add(TypeOfOffer.ADVERTISEMENT);

            ICollection<Product> products = await _services.ProductRepository.GetByFilter(productFilter, 1, 1);

            Assert.True(products.Count >= 1, products.Count().ToString());
        }
    }
}
