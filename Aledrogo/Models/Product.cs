using System;
using System.Collections.Generic;

namespace Aledrogo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<CategoryFieldValue> CategoryFieldsValues { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public decimal MinimalPrice { get; set; }
        public decimal Price { get; set; }
        public int ItemInStock { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
