using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public ICollection<Product> Products { get; set; }
        public string Title { get; set; }
    }
}
