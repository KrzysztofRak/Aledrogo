using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
