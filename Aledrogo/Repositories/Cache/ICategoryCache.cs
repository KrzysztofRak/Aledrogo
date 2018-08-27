using Aledrogo.Repositories.Cache.CacheDTO;
using System.Collections.Generic;

namespace Aledrogo.Repositories.Cache
{
    public interface ICategoryCache
    {
        ICollection<CategoryDTO> CategoryDTOs { get; set; }
        void LoadFromDatabase();
        IEnumerable<int> GetConcernedCategoriesIds(int categoryId);
    }
}
