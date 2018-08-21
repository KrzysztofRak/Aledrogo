using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class SpecificFieldValue
    {
        public int Id { get; set; }
        
        public virtual ICollection<SpecificField> SpecificFieldS { get; set; }
        public virtual ICollection<ProductSpecificFieldValues> Product_SpecificFieldValues { get; set; }

        public string Value { get; set; }
    }
}
