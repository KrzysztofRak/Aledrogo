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
        public async void GetByIdTest()
        {
            Product product = await _productRepository.GetById(ProductSeed.ladowarka.Id);

            Assert.Equal(ProductSeed.ladowarka, product);
        }

        [Fact]
        public async void GetAllBuyedByTest()
        {
            ICollection<Product> products = await _productRepository.GetAllBuyedBy(UserSeed.artur.Id);

            Assert.True(products.Contains(ProductSeed.telefon_xiaomi));
            Assert.True(products.Contains(ProductSeed.etui));
        }

        [Fact]
        public async void GetAllSelledByTest()
        {
            ICollection<Product> products = await _productRepository.GetAllSelledBy(UserSeed.krzysztof.Id);

            Assert.True(products.Contains(ProductSeed.laptop_uzywany));
            Assert.True(products.Contains(ProductSeed.arduino));
            Assert.True(products.Contains(ProductSeed.ladowarka));
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
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.ilosc_kolorow.Id, MinValue = 13000000, MaxValue = 30000000 });

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.telefon_xiaomi));
        }

        [Fact]
        public async void GetByNameSearchTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.SearchName = "laptop DELL";

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.laptop_uzywany));
        }

        [Fact]
        public async void GetByCategoryTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.CategoryId = CategorySeed.rtv_i_agd.Id;

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.konsola_ps4));
            Assert.True(products.Contains(ProductSeed.telewizor));
            Assert.True(products.Contains(ProductSeed.laptop_uzywany));
            Assert.True(products.Contains(ProductSeed.komputer_nowy));
            Assert.True(products.Contains(ProductSeed.pralka));
        }

        [Fact]
        public async void GetByPriceRangeTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.MinPrice = 600;
            productFilter.MaxPrice = 1500;

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.telewizor));
            Assert.True(products.Contains(ProductSeed.komputer_nowy));
        }

        [Fact]
        public async void GetByOfferTypeTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.OfferType = OfferType.AUCTION;

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.telewizor));
            Assert.True(products.Contains(ProductSeed.laptop_uzywany));
            Assert.True(products.Contains(ProductSeed.telefon_xiaomi));
        }

        [Fact]
        public async void GetByProductStatesTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.ProductStatesIds.Add(ProductStateSeed.nowy.Id);
            productFilter.ProductStatesIds.Add(ProductStateSeed.uszkodzony.Id);

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.arduino));
            Assert.True(products.Contains(ProductSeed.komputer_nowy));
            Assert.True(products.Contains(ProductSeed.etui));
            Assert.True(products.Contains(ProductSeed.powerbank));
        }

        [Fact]
        public async void GetByDeliveryMethodsTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.odbior_osobisty_po_przedplacie.Id);
            productFilter.DeliveryMethodsIds.Add(DeliveryMethodSeed.list_ekonomiczny.Id);

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.telefon_xiaomi));
            Assert.True(products.Contains(ProductSeed.powerbank));
            Assert.True(products.Contains(ProductSeed.arduino));
            Assert.True(products.Contains(ProductSeed.komputer_nowy));
        }

        [Fact]
        public async void GetBySpecificFieldsTest()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.pojemnosc_dysku.Id, MinValue = 1000 });
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.pamiec_ram.Id, MinValue = 4, MaxValue = 32 });
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.rodzaj_dysku.Id, SpecificFieldValueId = SpecificFieldValueSeed.rodzaj_dysku_hdd.Id });

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.True(products.Contains(ProductSeed.komputer_nowy));
        }

        [Fact]
        public async void GetBySpecificFieldsTest_ShouldNotFindAnyProducts()
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.pojemnosc_dysku.Id, MinValue = 1000 });
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.pamiec_ram.Id, MinValue = 32, MaxValue = 64 });
            productFilter.SpecificFieldsFilters.Add(new SpecificFieldFilter() { SpecificFieldId = SpecificFieldSeed.rodzaj_dysku.Id, SpecificFieldValueId = SpecificFieldValueSeed.rodzaj_dysku_hdd.Id });

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter);

            Assert.False(products.Any());
        }

        [Fact]
        public async void GetByPageIndexTest()
        {
            ProductFilter productFilter = new ProductFilter();
            int pageIndex = 3;
            int pageSize = 3;

            ICollection<Product> products = await _productRepository.GetByFilter(productFilter, pageIndex, pageSize);

            Assert.True(products.Count == pageSize);
            Assert.True(products.Where(p => p.Id > (pageIndex-1)*pageSize && p.Id <= pageIndex*pageSize).Count() == pageSize);
        }
    }
}
