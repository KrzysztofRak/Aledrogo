using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.DTO
{
    public class ProductDisplayDTO
    {
        public int Id { get; set; }
        public string SellerId { get; set; }
        public int ProductStateId { get; set; }

        public string Name { get; set; }

        public decimal MinimalPrice { get; set; }
        public decimal Price { get; set; }

        public byte ShippingTimeInWorkingDays { get; set; }

        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        public DateTime EndDate { get; set; }

        public bool IsHighlighted { get; set; } = false;
        public uint ViewsNumber { get; set; } = 0;
    }
}
