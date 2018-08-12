using System;
using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<CategorySpecificFieldValue> CategorySpecificFieldsValues { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal MinimalPrice { get; set; }
        public decimal Price { get; set; }
        public int ItemInStock { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
