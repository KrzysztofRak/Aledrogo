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
        Task<ICollection<Product>> GetAllBuyedBy(string userId);
        Task<IEnumerable<Product>> GetAllSelledBy(string userId);
        Task<IEnumerable<Product>> GetAllFromCategory(int categoryId);
        Task<IEnumerable<Product>> GetByNameSearchInCategory(string productName, int categoryId);
    }
}
