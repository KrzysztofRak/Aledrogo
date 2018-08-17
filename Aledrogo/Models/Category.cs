using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<CategorySpecificField> CategorySpecificFields { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
