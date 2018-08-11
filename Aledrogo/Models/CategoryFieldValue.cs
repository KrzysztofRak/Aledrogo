namespace Aledrogo.Models
{
    public class CategoryFieldValue
    {
        public int Id { get; set; }
        public int CategoryFieldId { get; set; }
        public int ProductId { get; set; }
        public CategoryField CategoryField { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }
}
