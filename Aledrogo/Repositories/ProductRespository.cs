using Aledrogo.Data;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
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
              var concernedCategoriesIds = _categoryCache.GetConcernedCategoriesIds(productFilter.CategoryId);

            ICollection<Product> products = _context.Products.Where(p => concernedCategoriesIds.Contains(p.CategoryId)
                                                     && p.Name.Contains(productFilter.SearchString)
                                                     && (productFilter.MinPrice == 0 || p.Price > productFilter.MinPrice || p.MinimalPrice > productFilter.MinPrice)
                                                     && (productFilter.MaxPrice == 0 || p.Price < productFilter.MaxPrice || p.MinimalPrice < productFilter.MaxPrice)
                                                     && productFilter.ProductStates.Contains(p.ProductState)
                                                     && productFilter.TypesOfOffers.Contains(p.TypeOfOffer)
                                                     //&& productFilter.DeliveryMethodTypes.Select(d => d.Id)
                                                     //   .Intersect(p.ProductDeliveryMethods.de)
                                                     //    Any()
                                                  ).ToList();
            //if (productFilter.SearchString != String.Empty && productFilter.CategoryId != -1)
            //    products = await GetBySearchInCategory(productFilter.SearchString, productFilter.CategoryId);
            //else if(productFilter.SearchString != String.Empty)
            //    products = await GetBySearch(productFilter.SearchString);
            //else if (productFilter.CategoryId != -1)
            //    products = await GetAllFromCategory(productFilter.CategoryId);


            //if(productFilter.MinPrice > 0)
            //    products = products.Where(p => p.Price > productFilter.MinPrice || p.MinimalPrice > productFilter.MinPrice).ToList();
            //if(productFilter.MaxPrice > 0)
            //    products = products.Where(p => p.Price < productFilter.MaxPrice || p.MinimalPrice < productFilter.MaxPrice).ToList();

            //if(productFilter.ProductStates != null)
            //    products = products.Where(p => productFilter.ProductStates.Contains(p.ProductState)).ToList();

            //if (productFilter.TypesOfOffers != null)
            //    products = products.Where(p => productFilter.TypesOfOffers.Contains(p.TypeOfOffer)).ToList();
            //   categoryProducts = categoryProducts.Where(p => p.P)
            //IEnumerable<Product> categoryProducts = await GetAllFromCategory(categoryId);
            //IEnumerable<Product> categoryProducts = await GetAllFromCategory(categoryId);

            //return _context.Products.Where(p => p.Name.Contains(productName));
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
