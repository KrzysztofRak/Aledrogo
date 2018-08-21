namespace Aledrogo.Models
{
    public class ProductSpecificFieldValues
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SpecificFieldValueId { get; set; }

        public Product Product { get; set; }
        public SpecificFieldValue SpecificFieldValue { get; set; }
    }
}
