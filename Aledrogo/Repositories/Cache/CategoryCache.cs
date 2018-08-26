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
            Load();
        }

        public void Load()
        {
            Categories = _context.Categories.ToList();
            CategoryDTOs = new List<CategoryDTO>();

            foreach(Category category in Categories)
            {
                CategoryDTO cachedCategoryDTO = new CategoryDTO();
                cachedCategoryDTO.CategoryId = category.Id;
                AddChildCategoriesIds(category.Id, cachedCategoryDTO.ChildCategoriesIds);

                CategoryDTOs.Add(cachedCategoryDTO);
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

        private void AddChildCategoriesIds(int parentCategoryId, ICollection<int> childCategoriesIds)
        {
            foreach (Category category in Categories)
            {
                if (category.ParentCategoryId == parentCategoryId)
                {
                    childCategoriesIds.Add(category.Id);
                    AddChildCategoriesIds(category.Id, childCategoriesIds);
                }
            }
        }
    }
}
