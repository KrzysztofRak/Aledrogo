namespace Aledrogo.Models
{
    public class SpecyficationValueProduct
    {
        public int Id { get; set; }
        public int SpecyficationValueId { get; set; }
        public int ProductId { get; set; }
        public SpecyficationValue SpecyficationValue { get; set; }
        public Product Product { get; set; }
    }
}
