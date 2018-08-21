using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class SpecificField
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<SpecificFieldValue> SpecificFieldValues { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool IsRequired { get; set; } = false;
        public bool IsCustomNumericValue { get; set; } = false;
        public int? MinNumericValue { get; set; }
        public int? MaxNumericValue { get; set; }
    }
}
