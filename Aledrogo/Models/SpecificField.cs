using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class SpecificField
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public int SpecificFieldValueId { get; set; }

        public virtual Category Category { get; set; }
        public virtual SpecificFieldValue SpecificFieldValue { get; set; }


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
