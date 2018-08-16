namespace Aledrogo.Models
{
    public class CategorySpecificFieldValue
    {
        public int Id { get; set; }

        public int CategoryFieldId { get; set; }
        public virtual CategorySpecificField CategorySpecificField { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        
        public string Value { get; set; }
    }
}
