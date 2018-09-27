namespace Aledrogo.DTO
{
    public class DeliveryMethodDTO
    {
        public string Name { get; set; }
        public bool IsSafe { get; set; }
        public decimal Price { get; set; }
        public byte DeliveryTime { get; set; }
    }
}
