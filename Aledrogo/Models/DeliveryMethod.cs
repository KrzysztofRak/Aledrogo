using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class DeliveryMethod
    {
        public int Id { get; set; }

        public int DeliveryMethodTypeId { get; set; }
        public virtual DeliveryMethodType DeliveryMethodType { get; set; }

        public virtual ICollection<Product_DeliveryMethod> Products_DeliveryMethods { get; set; }

        public string Name { get; set; }
        public bool IsSafe { get; set; } = true;
        public decimal? Price { get; set; } = null;
    }
}
