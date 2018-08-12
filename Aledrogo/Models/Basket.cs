namespace Aledrogo.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
