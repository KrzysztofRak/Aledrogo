namespace Aledrogo.Models
{
    public class Product_DeliveryMethod
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int DeliveryMethodId { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }
        
        decimal Price { get; set; }
    }
}
