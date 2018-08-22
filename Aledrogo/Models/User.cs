using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class User : IdentityUser
    {
        public uint SoldItems { get; set; } = 0;
        public uint BuyedItems { get; set; } = 0;

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<TransactionRatingResponse> TransactionRatingResponses { get; set; }
        public virtual ICollection<TransactionRating> TransactionRatings { get; set; }
    }
}
