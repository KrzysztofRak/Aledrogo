﻿namespace Aledrogo.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
