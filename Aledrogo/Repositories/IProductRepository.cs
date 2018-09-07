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
        Task<Product> GetById(int productId);
        Task<ICollection<Product>> GetAllBuyedBy(string userId, int? pageIndex = null, int? pageSize = null);
        Task<ICollection<Product>> GetAllSelledBy(string userId, int? pageIndex = null, int? pageSize = null);
        Task<ICollection<Product>> GetByFilter(ProductFilter productFilter, int? pageIndex = null, int? pageSize = null);
    }
}
