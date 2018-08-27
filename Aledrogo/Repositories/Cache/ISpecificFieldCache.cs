using Aledrogo.Models;
using System.Collections.Generic;

namespace Aledrogo.Repositories.Cache
{
    public interface ISpecificFieldCache
    {
        void LoadFromDatabase();
        IEnumerable<SpecificField> GetCategorySpecificFields(int categoryId);
    }
}
