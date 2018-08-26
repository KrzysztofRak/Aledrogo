using Aledrogo.Repositories.Cache.CacheDTO;
using System.Collections.Generic;

namespace Aledrogo.Repositories.Cache
{
    public interface ICategoryCache
    {
        void Load();
        ICollection<CategoryDTO> CategoryDTOs { get; set; }
        IEnumerable<int> GetConcernedCategoriesIds(int categoryId);
    }
}
