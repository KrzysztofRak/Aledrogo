using Aledrogo.Data;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public class ProductRespository : IProductRepository
    {
        private readonly AledrogoContext _context;

        public ProductRespository(AledrogoContext context)
        {
            _context = context;
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

        public async Task<IEnumerable<Product>> GetAllFromCategory(int categoryId)
        {
            ICollection<int> concernedCategoriesIds = new List<int>(); // @@@ Tutaj potrzebny cache dla kategorii @@@
            return _context.Products.Where(p => concernedCategoriesIds.Contains(p.CategoryId)).ToList();
        }

        public async Task<IEnumerable<Product>> GetByNameSearchInCategory(string productName, int categoryId)
        {
            return _context.Products.Where(p => p.Name.Contains(productName));
        }

        public async Task<IEnumerable<Product>> GetByFilters(ProductFilter productFilter, int categoryId)
        {
            //IEnumerable<Product> categoryProducts = await GetAllFromCategory(categoryId);
            //IEnumerable<Product> categoryProducts = await GetAllFromCategory(categoryId);

            //return _context.Products.Where(p => p.Name.Contains(productName));
            return null;
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
            catch(Exception ex)
            {
              
            }
        }

        public IEnumerable<Product> FilterProductsBy(ProductFilter productFilter)
        {
            return null;
        }
    }
}
