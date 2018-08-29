using Aledrogo.ModelFilters;
using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetByFilter(ProductFilter productFilter, int pageIndex, int pageSize);
        Task<Product> GetById(int productId);
        Task<ICollection<Product>> GetAllBuyedBy(string userId);
        Task<IEnumerable<Product>> GetAllSelledBy(string userId);
        Task<ICollection<Product>> GetAllFromCategory(int categoryId);
        Task<ICollection<Product>> GetBySearchInCategory(string productName, int categoryId);
    }
}
