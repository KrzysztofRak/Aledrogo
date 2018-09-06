using Aledrogo.Data.DataToSeed;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories;
using Aledrogo.Repositories.Filters.FilterDTOs;
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
        public async void GetByFilterTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.SearchName = "Redmi Note";
            productFilter.MinPrice = 200;
            productFilter.MaxPrice = 1400;
            productFilter.CategoryId = 2;

            productFilter.OfferType = OfferType.AUCTION | OfferType.BUY_IT_NOW;

            productFilter.ProductStatesIds.Add(ProductStateSeed.uzywany.Id);
            productFilter.ProductStatesIds.Add(ProductStateSeed.powystawowy.Id);
            productFilter.ProductStatesIds.Add(ProductStateSeed.uszkodzony.Id);

            productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.przesylka_kurierska.Id);
            productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.odbior_osobisty_po_przedplacie.Id);

            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.interfejs.Id, SpecificFieldValueId = SpecificFieldValueSeed.interfejs_miui_9.Id });
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.kolor.Id, SpecificFieldValueId = SpecificFieldValueSeed.kolor_czarny.Id });

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter, 1, 1);

            Assert.True(products.Contains(ProductSeed.telefon_xiaomi));
        }

        [Fact]
        public async void GetByFilterTest2()
        {
            GetByFilterTest();
        }
    }
}
