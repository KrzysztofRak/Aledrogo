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

        private IEnumerable<Category> Categories { get; set; }

        public ICollection<CategoryDTO> CategoryDTOs { get; set; }

        public CategoryCache(AledrogoContext context)
        {
            _context = context;
            LoadFromDatabase();
        }

        public void LoadFromDatabase()
        {
            Categories = _context.Categories.ToList();
            CategoryDTOs = new List<CategoryDTO>();

            foreach (Category category in Categories)
            {
                CategoryDTO cachedCategoryDTO = new CategoryDTO();
                cachedCategoryDTO.CategoryId = category.Id;
                AppendChildCategoriesIds(category.Id, cachedCategoryDTO.ChildCategoriesIds);

                CategoryDTOs.Add(cachedCategoryDTO);
            }
        }

        private void AppendChildCategoriesIds(int parentCategoryId, ICollection<int> childCategoriesIds)
        {
            IEnumerable<Category> firstLevelChildCategories = Categories.Where(c => c.ParentCategoryId == parentCategoryId);

            foreach (Category category in firstLevelChildCategories)
            {
                childCategoriesIds.Add(category.Id);
                AppendChildCategoriesIds(category.Id, childCategoriesIds);
            }
        }

        public IEnumerable<int> GetConcernedCategoriesIds(int categoryId)
        {
            ICollection<int> concernedCategoriesIds = CategoryDTOs
                                          .Where(c => c.CategoryId == categoryId)
                                          .First().ChildCategoriesIds;

            concernedCategoriesIds.Add(categoryId);

            return concernedCategoriesIds;
        }
    }
}
