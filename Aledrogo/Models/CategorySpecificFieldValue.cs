namespace Aledrogo.Models
{
    public class CategorySpecificFieldValue
    {
        public int Id { get; set; }
        public int CategoryFieldId { get; set; }
        public int ProductId { get; set; }
        public CategorySpecificField CategorySpecificField { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }
}
