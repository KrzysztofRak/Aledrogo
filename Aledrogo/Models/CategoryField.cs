using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class CategoryField
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<CategoryFieldValue> CategoryFieldValues { get; set; }
        public string Name { get; set; }
    }
}
