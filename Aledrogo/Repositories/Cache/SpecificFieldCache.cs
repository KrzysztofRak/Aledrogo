using Aledrogo.Data;
using Aledrogo.Models;
using Aledrogo.Repositories.Cache.CacheDTO;
using System.Collections.Generic;
using System.Linq;

namespace Aledrogo.Repositories.Cache
{
    public class SpecificFieldCache : ISpecificFieldCache
    {
        private readonly AledrogoContext _context;

        private IEnumerable<SpecificField> SpecificFields { get; set; }

        public SpecificFieldCache(AledrogoContext context)
        {
            _context = context;
            LoadFromDatabase();
        }

        public void LoadFromDatabase()
        {
            SpecificFields = _context.SpecificFields.ToList();
        }

        public IEnumerable<SpecificField> GetCategorySpecificFields(int categoryId)
        {
            return SpecificFields.Where(f => f.CategoryId == categoryId).ToList();
        }
    }
}
