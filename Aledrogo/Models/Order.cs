using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string CustomerId { get; set; }
        public virtual User Customer { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int DeliveryMethodId { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }

        public virtual TransactionRating TransactionRating { get;set;}

        [Required]
        [Range(minimum: 1, maximum: 10000)]
        public int Quantity { get; set; }

        public decimal Value { get; set; }
        public decimal DeliveryValue { get; set; }

        public bool PaymentCompleted { get; set; } = false;
    }
}
