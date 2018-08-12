using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentCatrgoryId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<CategorySpecificField> CategorySpecificFields { get; set; }
        public string Name { get; set; }
    }
}
