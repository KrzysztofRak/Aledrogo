using Aledrogo.Repositories.Cache.CacheDTO;
using System.Collections.Generic;

namespace Aledrogo.Repositories.Cache
{
    public interface ICategoryCache
    {
        IEnumerable<int> GetConcernedCategoriesIds(int categoryId);
        void LoadFromDatabase();
    }
}
