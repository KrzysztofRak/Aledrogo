using System.Collections.Generic;

namespace Aledrogo.DTO
{
    public class BasketDTO
    {
        public ICollection<BasketProductDTO> BasketProducts { get; set; }
        public ICollection<AddressDTO> Addresses{ get; set; }
        public int SelectedAddressId { get; set; }
        public DeliveryMethodDTO SelectedDeliveryMethod { get; set; }
    }
}
