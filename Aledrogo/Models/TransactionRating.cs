using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aledrogo.Models
{
    public class TransactionRating
    {
        [Key]
        public int Id { get; set; }
        public string SellerId { get; set; }
        public string CustomerId { get; set; }
        public int ProductId { get; set; }
        public int DeliveryMethodId { get; set; }

        [ForeignKey("SellerId")]
        public virtual User Seller { get; set; }
        [ForeignKey("CustomerId")]
        public virtual User Customer { get; set; }

        public virtual Product Product { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }

        public bool IsPositive { get; set; }

        [Required]
        [Range(1, 5)]
        public byte CompatibilityWithDescriptionRating { get; set; }

        [Required]
        [Range(1, 5)]
        public byte ShippingTimeRating { get; set; }

        [Required]
        [Range(1, 5)]
        public byte ShippingCostRating { get; set; }

        [Required]
        [Range(1, 5)]
        public byte CustomerServiceRating { get; set; }

        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
