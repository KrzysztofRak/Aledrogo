using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class ProductDeliveryMethod
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DeliveryMethodId { get; set; }
        public virtual Product Product  { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }
        public ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }
    }
}
