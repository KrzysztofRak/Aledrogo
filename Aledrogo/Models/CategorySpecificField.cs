using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class CategorySpecificField
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CategorySpecificFieldValue> CategorySpecificFieldValues { get; set; }

        [Required]
        [MaxLength(100)]
        public string FieldName { get; set; }
    }
}
