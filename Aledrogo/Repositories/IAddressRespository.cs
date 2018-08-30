using Aledrogo.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public interface IAddressRespository
    {
        Task<ICollection<AddressDTO>> GetAllUserAddresses();
        Task<AddressDTO> GetAddressById(int id);
        Task<bool> DeleteAddressById(int id);
        Task<bool> AddAddress(AddressDTO dto);
    }
}
