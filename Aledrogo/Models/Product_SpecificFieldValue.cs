namespace Aledrogo.Models
{
    public class Product_SpecificFieldValue
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }

        public int SpecificFieldValueId { get; set; }
        public SpecificFieldValue SpecificFieldValue { get; set; }
    }
}
