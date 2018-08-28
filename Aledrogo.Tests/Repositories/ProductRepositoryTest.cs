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
    public class ProductRepositoryTest
    {
        private ProductRespository _productsRepository;

        public ProductRepositoryTest()
        {
            _productsRepository = Service.Provider.GetRequiredService<ProductRespository>();
        }

        [Fact]
        public async void GetAllFromCategoryTest()
        {
            ICollection<Product> products = await _productsRepository.GetAllFromCategory(1);

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

            ICollection<Product> products = await _productsRepository.GetByFilter(productFilter, 1, 1);

            Assert.True(products.Count >= 1, products.Count().ToString());
        }
    }
}
