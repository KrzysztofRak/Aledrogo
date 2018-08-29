using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories.Cache.CacheDTO;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Repositories.Cache
{
    public class CategoryCache : ICategoryCache
    {
        private readonly AledrogoContext _context;

        private IEnumerable<Category> categories;
        private ICollection<CategoryDTO> categoriesDTOs;

        public CategoryCache(AledrogoContext context)
        {
            _context = context;
            LoadFromDatabase();
        }

        public IEnumerable<int> GetConcernedCategoriesIds(int categoryId)
        {
            ICollection<int> concernedCategoriesIds = categoriesDTOs
                                          .First(c => c.CategoryId == categoryId).ChildCategoriesIds;

            concernedCategoriesIds.Add(categoryId);

            return concernedCategoriesIds;
        }

        public void LoadFromDatabase()
        {
            categories = _context.Categories.ToList();
            categoriesDTOs = new List<CategoryDTO>();

            foreach (Category category in categories)
            {
                CategoryDTO cachedCategoryDTO = new CategoryDTO();
                cachedCategoryDTO.CategoryId = category.Id;
                AppendChildCategoriesIds(category.Id, cachedCategoryDTO.ChildCategoriesIds);

                categoriesDTOs.Add(cachedCategoryDTO);
            }
        }

        private void AppendChildCategoriesIds(int parentCategoryId, ICollection<int> childCategoriesIds)
        {
            IEnumerable<Category> firstLevelChildCategories = categories.Where(c => c.ParentCategoryId == parentCategoryId);

            foreach (Category category in firstLevelChildCategories)
            {
                childCategoriesIds.Add(category.Id);
                AppendChildCategoriesIds(category.Id, childCategoriesIds);
            }
        }
    }
}
