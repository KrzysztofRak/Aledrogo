using Aledrogo.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<CategorySpecificFieldValue> CategorySpecificFieldsValues { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        public decimal MinimalPrice { get; set; }
        public decimal Price { get; set; }
        [Required]
        [Range(0,999)]
        public int ItemInStock { get; set; }
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        [DateRange(1,20)]
        public DateTime EndDate { get; set; }
    }
}
