using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Models
{
    public class TransactionRatingResponse
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int TransactionRatingId { get; set; }
        public virtual TransactionRating TransactionRating { get; set; }

        [Required]
        [MaxLength(500)]
        public string Response { get; set; }
    }
}
