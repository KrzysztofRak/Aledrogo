﻿using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [Range(minimum:1, maximum:999)]
        public int Quantity { get; set; }
    }
}
