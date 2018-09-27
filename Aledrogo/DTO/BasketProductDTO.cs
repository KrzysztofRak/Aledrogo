using System.Collections.Generic;

namespace Aledrogo.DTO
{
    public class BasketProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SellerName { get; set; }
        public decimal Price { get; set; }
        public ICollection<DeliveryMethodDTO> DeliveryMethodDTOs { get; set; }
        public int ProductStateId { get; set; }
        public string MiniatureUrl { get; set; }
        public ushort Quantity { get; set; }
    }
}
