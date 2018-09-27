using System.ComponentModel.DataAnnotations;

namespace Aledrogo.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
