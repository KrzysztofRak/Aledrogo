using Aledrogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.ModelFilters
{
    public class ProductFilter
    {
        public string Name { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public ProductState State { get; set; }
        public bool AuctionsOnly { get; set; }
        public bool BuyItNowOnly { get; set; }

    }
}
