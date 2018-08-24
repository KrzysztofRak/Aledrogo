using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories.Cache.CacheDTO
{
    public class CategoryCacheDTO
    {
        public int CategoryId { get; set; }
        public ICollection<int> ChildCategoriesIds { get; set; }
    }
}
