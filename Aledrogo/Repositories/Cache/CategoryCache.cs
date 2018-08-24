using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories.Cache.CacheDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories.Cache
{
    public class CategoryCache : ICategoryCache
    {
        private readonly AledrogoContext _context;

        public ICollection<CategoryCacheDTO> CategoriesCache { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public CategoryCache(AledrogoContext context)
        {
            _context = context;
            InitializeCategoriesCache();
        }

        private void InitializeCategoriesCache()
        {
            CategoriesCache = new List<CategoryCacheDTO>();
            Categories = _context.Categories.ToList();

            foreach(Category category in Categories)
            {
                CategoryCacheDTO cachedCategory = new CategoryCacheDTO();
                cachedCategory.CategoryId = category.Id;
                AddChildCategoriesIdsOf(category.Id, cachedCategory);

                CategoriesCache.Add(cachedCategory);
            }
        }

        private void AddChildCategoriesIdsOf(int parentCategoryId, CategoryCacheDTO cachedCategoryToAddTo)
        {
            foreach (Category category in Categories)
            {
                if (category.ParentCategoryId == parentCategoryId)
                {
                    cachedCategoryToAddTo.ChildCategoriesIds.Add(category.Id);
                    AddChildCategoriesIdsOf(category.Id, cachedCategoryToAddTo);
                }
            }
        }
    }
}
