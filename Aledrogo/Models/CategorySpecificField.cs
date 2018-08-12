using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class CategorySpecificField
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<CategorySpecificFieldValue> CategorySpecificFieldValues { get; set; }
        public string Name { get; set; }
    }
}
