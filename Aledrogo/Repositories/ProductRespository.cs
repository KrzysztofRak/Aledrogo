using Aledrogo.Data;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories.Cache;
using Aledrogo.Repositories.Filters.FilterDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public class ProductRespository : IProductRepository
    {
        private readonly AledrogoContext _context;
        private readonly ICategoryCache _categoryCache;

        public ProductRespository(AledrogoContext context, ICategoryCache categoryCache)
        {
            _context = context;
            _categoryCache = categoryCache;
        }

        public async Task Add(Product product)
        {
            try
            {
                _context.Products.Add(product);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task Update(Product product)
        {
            try
            {
                Product _product = await GetById(product.Id);
                _product = product;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
        }

        public void Remove(Product product)
        {
            try
            {
                _context.Products.Remove(product);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task<Product> GetById(int productId)
        {
            return _context.Products.Where(p => p.Id == productId).FirstOrDefault();
        }

        public async Task<ICollection<Product>> GetAllBuyedBy(string userId, int? pageIndex = null, int? pageSize = null)
        {
            IQueryable<Product> products = _context.Products.Where(p => p.Orders.Select(o => o.CustomerId).Contains(userId));
            products = await FilterByPageIndex(products, pageIndex, pageSize);
            return await products.ToListAsync();
        }

        public async Task<ICollection<Product>> GetAllSelledBy(string userId, int? pageIndex = null, int? pageSize = null)
        {
            IQueryable<Product> products = _context.Products.Where(p => p.SellerId == userId);
            products = await FilterByPageIndex(products, pageIndex, pageSize);
            return await products.ToListAsync();
        }

        public async Task<ICollection<Product>> GetByFilter(ProductFilter productFilter, int? pageIndex = null, int? pageSize = null)
        {
            IQueryable<Product> products = _context.Products;

            products = await FilterByNameSearch(products, productFilter.SearchName);
            products = await FilterByCategory(products, productFilter.CategoryId);
            products = await FilterByPriceRange(products, productFilter.MinPrice, productFilter.MaxPrice);
            products = await FilterByOfferType(products, productFilter.OfferType);
            products = await FilterByProductStates(products, productFilter.ProductStatesIds);
            products = await FilterByDeliveryMethods(products, productFilter.DeliveryMethodsIds);
            products = await FilterBySpecificFields(products, productFilter.SpecificFieldsFilters);
            products = await FilterByPageIndex(products, pageIndex, pageSize);

            return await products.ToListAsync();
        }

        private async Task<IQueryable<Product>> FilterByPageIndex(IQueryable<Product> products, int? pageIndex = null, int? pageSize = null)
        {
            if (pageIndex == null || pageSize == null)
                return products;

            int numberOfElementsOnPreviousPages = (int)((pageIndex - 1) * pageSize);

            return products.Skip(numberOfElementsOnPreviousPages).Take((int)pageSize);
        }

        private async Task<IQueryable<Product>> FilterByNameSearch(IQueryable<Product> products, string searchName)
        {
            if (searchName == "")
                return products;
            else
                return products.Where(p => p.Name.Contains(searchName));
        }

        private async Task<IQueryable<Product>> FilterByCategory(IQueryable<Product> products, int categoryId)
        {
            if (categoryId == ProductFilter.CATEGORY_NOT_SELECTED)
                return products;

            IEnumerable<int> concernedCategoriesIds = _categoryCache.GetConcernedCategoriesIds(categoryId);
            return _context.Products.Where(p => concernedCategoriesIds.Contains(p.CategoryId));
        }

        private async Task<IQueryable<Product>> FilterByPriceRange(IQueryable<Product> products, decimal minPrice, decimal maxPrice)
        {
            return products.Where(p => (minPrice == ProductFilter.PRICE_UNDEFINED ||
                                        p.Price >= minPrice ||
                                        p.MinimalPrice >= minPrice)

                                    && (maxPrice == ProductFilter.PRICE_UNDEFINED ||
                                        p.Price <= maxPrice ||
                                        p.MinimalPrice <= maxPrice));
        }

        private async Task<IQueryable<Product>> FilterByOfferType(IQueryable<Product> products, OfferType offerType)
        {
            return products.Where(p => (offerType.HasFlag(OfferType.ANY) ||
                                       (offerType.HasFlag(OfferType.BUY_IT_NOW) && p.Price > p.MinimalPrice) ||
                                       (offerType.HasFlag(OfferType.AUCTION) && p.MinimalPrice > 0)));
        }

        private async Task<IQueryable<Product>> FilterByProductStates(IQueryable<Product> products, IEnumerable<int> productStatesIds)
        {
            return products.Where(p => (!productStatesIds.Any() ||
                                         productStatesIds.Contains(p.ProductStateId)));

        }

        private async Task<IQueryable<Product>> FilterByDeliveryMethods(IQueryable<Product> products, IEnumerable<int> deliveryMethodsIds)
        {
            return products.Where(p => (!deliveryMethodsIds.Any() ||
                                         p.ProductDeliveryMethods
                                          .Where(pdm => deliveryMethodsIds
                                           .Contains(pdm.DeliveryMethodId))
                                          .Any()));
        }

        private async Task<IQueryable<Product>> FilterBySpecificFields(IQueryable<Product> products, IEnumerable<SpecificFieldFilter> specificFieldsFilters)
        {
            if (!specificFieldsFilters.Any())
                return products;

            return products.Where(p => (specificFieldsFilters // CHECK IF PRODUCT CONTAINS SpecificFieldValue FOR SpecificField
                                        .All(sff =>
                                                   (sff.SpecificFieldValueId != null // CHECK IF SpecificFieldValue OF PRODUCT EQUALS TO SpecificFieldValue IN FILTER
                                                    && p.ProductSpecificFieldsValues
                                                     .Where(psfv => psfv.SpecificFieldValue.SpecificFieldId == sff.SpecificFieldId
                                                      && psfv.SpecificFieldValueId == sff.SpecificFieldValueId)
                                                     .Any()) ||

                                                   (p.ProductSpecificFieldsValues // CHECK IF SpecificFieldValue OF PRODUCT IS IN RANGE SPECIFIED IN FILTER
                                                    .Where(psfv => psfv.SpecificFieldValue.SpecificFieldId == sff.SpecificFieldId
                                                     && (sff.MinValue == null || int.Parse(psfv.SpecificFieldValue.Value) >= sff.MinValue)
                                                     && (sff.MaxValue == null || int.Parse(psfv.SpecificFieldValue.Value) <= sff.MaxValue))
                                                    .Any()))));
        }
    }
}
