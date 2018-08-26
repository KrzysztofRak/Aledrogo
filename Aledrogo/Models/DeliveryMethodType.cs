using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class DeliveryMethodType
    {
        public int Id { get; set; }

        public virtual ICollection<DeliveryMethod> DeliveryMethods { get; set; }

        public string Name { get; set; }
    }
}
