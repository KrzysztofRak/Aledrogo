using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class DeliveryMethod
    {
        public int Id { get; set; }

        public virtual ICollection<Product_DeliveryMethod> Products_DeliveryMethods { get; set; }

        public string Name { get; set; }
        public bool IsSafe { get; set; } = true;
        public decimal Price { get; set; }
        [Required]
        [Range(1, 14)]
        public byte DeliveryTime { get; set; }
    }
}
