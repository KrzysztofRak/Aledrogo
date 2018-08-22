using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public string BidderId { get; set; }
        public virtual User Bidder { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public decimal Value { get; set; }
        public DateTime DateOfSubmission { get; set; } = DateTime.UtcNow;
    }
}
