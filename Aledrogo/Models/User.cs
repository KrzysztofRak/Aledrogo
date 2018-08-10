using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class User : IdentityUser
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Address> GetAddresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}
