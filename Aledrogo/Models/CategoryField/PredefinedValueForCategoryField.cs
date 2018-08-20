using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class PredefinedValueForCategoryField
    {
        public int Id { get; set; }

        public int CategoryFieldId { get; set; }
        public virtual CategoryField CategoryField { get; set; }

        [MaxLength(100)]
        public string Value { get; set; }
    }
}
