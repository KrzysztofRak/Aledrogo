using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class SpecificFieldValue
    {
        public int Id { get; set; }

        public int SpecificFieldId { get; set; }
        public virtual SpecificField SpecificField { get; set; }

        public virtual ICollection<Product_SpecificFieldValue> Products_SpecificFieldValues { get; set; }

        public string Value { get; set; }
    }
}
