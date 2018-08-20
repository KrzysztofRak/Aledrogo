using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class CategoryField
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<PredefinedValueForCategoryField> PredefinedValuesForCategoryField { get; set; }
        public virtual ICollection<SelectedValueForCategoryField> SelectedValuesForCategoryField { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool IsRequired { get; set; } = false;
        public bool CanBeUnknown { get; set; } = true;
        public bool CustomNumericValueAllowed { get; set; }
        public int? MinNumber { get; set; }
        public int? MaxNumber { get; set; }
    }
}
