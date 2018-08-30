using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class ProductState
    {
        public int Id { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public string Name { get; set; }
    }
}
