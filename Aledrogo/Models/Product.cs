using Aledrogo.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aledrogo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string SellerId { get; set; }
        public virtual User Seller { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<SelectedValueForCategoryField> SelectedValuesForCategoryFields { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; }

        public decimal MinimalPrice { get; set; }
        public decimal Price { get; set; }
        public int DaysForReturn { get; set; }

        [Required]
        public ProductState State { get; set; }

        [Required]
        [Range(0, 10000)]
        public int ItemsInStock { get; set; }

        [Required]
        [Range(1, 14)]
        public byte ShippingTimeInWorkingDays {get;set;}

        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        [DateRange(1,20)]
        public DateTime EndDate { get; set; }
    }
}
