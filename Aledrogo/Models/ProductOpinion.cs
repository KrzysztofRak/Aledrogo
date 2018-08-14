using System;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class ProductOpinion
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
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
