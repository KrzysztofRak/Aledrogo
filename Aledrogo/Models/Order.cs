﻿namespace Aledrogo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public Address Address { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
