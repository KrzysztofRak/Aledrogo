using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class TransactionRating
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int SellerId { get; set; }
        public virtual User Seller { get; set; }

        public virtual ICollection<TransactionRatingResponse> TransactionRatingResponses { get; set; }

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
