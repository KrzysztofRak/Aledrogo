using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public string Country { get; set; }
        public string FullName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
