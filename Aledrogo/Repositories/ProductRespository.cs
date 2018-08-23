using Aledrogo.Data;
using Aledrogo.ModelFilters;
using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Repositories
{
    public class ProductRespository
    {
        private AledrogoContext context;

        public ProductRespository(AledrogoContext context)
        {
            this.context = context;
        }

        public Product GetById(int productId)
        {
            return context.Products.Where(p => p.Id == productId).FirstOrDefault();
        }

        public void Remove(Product product)
        {
            try
            {
                context.Products.Remove(product);
            }
            catch(Exception ex)
            {
              
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product _product = GetById(product.Id);
                _product = product;
            }
            catch (Exception ex)
            {

            }
        }

        public IEnumerable<Product> SearchByName(string productName)
        {
            return context.Products.Where(p => p.Name.Contains(productName));
        }

        public IEnumerable<Product> FilterProductsBy(ProductFilter productFilter)
        {
            return null;
        }
    }
}
