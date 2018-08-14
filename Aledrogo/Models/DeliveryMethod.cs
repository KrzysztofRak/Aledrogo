using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class DeliveryMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsSafe { get; set; }
        public bool ExpectedDeliveryTime { get; set; }
        public virtual ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }
    }
}
