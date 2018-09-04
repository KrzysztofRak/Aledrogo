using Aledrogo.Data;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using Aledrogo.Models.Enums;
using Aledrogo.Repositories.Cache;
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

        public async Task<Product> GetById(int productId)
        {
            return _context.Products.Where(p => p.Id == productId).FirstOrDefault();
        }

        public async Task<ICollection<Product>> GetAllBuyedBy(string userId)
        {
            return _context.Products.Where(p => p.Orders.Contains(p.Orders.Where(o => o.CustomerId == userId).First())).ToList();
        }

        public async Task<IEnumerable<Product>> GetAllSelledBy(string userId)
        {
            return _context.Products.Where(p => p.SellerId == userId).ToList();
        }

        public async Task<ICollection<Product>> GetAllFromCategory(int categoryId)
        {
            IEnumerable<int> concernedCategoriesIds = _categoryCache.GetConcernedCategoriesIds(categoryId);

            return _context.Products.Where(p => concernedCategoriesIds.Contains(p.CategoryId)).ToList();
        }

        public async Task<ICollection<Product>> GetBySearchInCategory(string serchString, int categoryId)
        {
            IEnumerable<int> concernedCategoriesIds = _categoryCache.GetConcernedCategoriesIds(categoryId);

            return _context.Products.Where(p => p.Name.Contains(serchString) && concernedCategoriesIds.Contains(p.CategoryId)).ToList();
        }

        public async Task<ICollection<Product>> GetBySearch(string serchString)
        {
            return _context.Products.Where(p => p.Name.Contains(serchString)).ToList();
        }

        public async Task<ICollection<Product>> GetByFilter(ProductFilter productFilter, int pageIndex, int pageSize)
        {
            IEnumerable<int> concernedCategoriesIds = (productFilter.CategoryId == ProductFilter.CATEGORY_NOT_SELECTED) ?
                                                       null : _categoryCache.GetConcernedCategoriesIds(productFilter.CategoryId);

            ICollection<Product> products = _context.Products.ToList();
            
            products = products.Where(p => (concernedCategoriesIds == null || concernedCategoriesIds.Contains(p.CategoryId))
                                                     && p.Name.Contains(productFilter.SearchString)
                                                     && (productFilter.MinPrice == ProductFilter.PRICE_UNDEFINED || p.Price > productFilter.MinPrice || p.MinimalPrice > productFilter.MinPrice)
                                                     && (productFilter.MaxPrice == ProductFilter.PRICE_UNDEFINED || p.Price < productFilter.MaxPrice || p.MinimalPrice < productFilter.MaxPrice)
                                                     && (productFilter.TypeOfOffer == TypeOfOffer.ANY || productFilter.TypeOfOffer.HasFlag(p.TypeOfOffer))
                                                     && (!productFilter.ProductStateIds.Any() || productFilter.ProductStateIds.Contains(p.ProductStateId))
                                                     && (!productFilter.DeliveryMethodTypeIds.Any() || p.ProductDeliveryMethods
                                                        .Where(pdm => productFilter.DeliveryMethodTypeIds.Contains(pdm.DeliveryMethod.DeliveryMethodTypeId)).Any())
                                                    ).ToList();
            return products;
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

        public IEnumerable<Product> FilterProductsBy(ProductFilter productFilter)
        {
            return null;
        }
    }
}
