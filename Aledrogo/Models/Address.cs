using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(10)]
        public string PostCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
