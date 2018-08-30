using Aledrogo.Data;
using Aledrogo.DTO;
using Aledrogo.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public class AddressRespository : IAddressRespository
    {
        private readonly IMapper _mapper;
        private readonly AledrogoContext _context;
        public AddressRespository(IMapper mapper, AledrogoContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<bool> AddAddress(AddressDTO dto)
        {
            string userId = (await _context.Users.FirstOrDefaultAsync(m => m.UserName == dto.UserName)).Id;
            if(userId == null)
            {
                return false;
            }

            Address newAddress = _mapper.Map<Address>(dto);
            newAddress.UserId = userId;

            await _context.Addresses.AddAsync(newAddress);

            return true;
        }

        public async Task<bool> DeleteAddressById(int id)
        {
            Address deleteAddress = await _context.Addresses.FirstOrDefaultAsync(m => m.Id == id);
            if (deleteAddress == null)
            {
                return false;
            }

            _context.Addresses.Remove(deleteAddress);

            return true;
        }

        public async Task<AddressDTO> GetAddressById(int id)
        {
            Address address = await _context.Addresses.FirstOrDefaultAsync(m => m.Id == id);
            AddressDTO dto = _mapper.Map<AddressDTO>(address);

            return dto;
        }
        
        public async Task<ICollection<AddressDTO>> GetAllUserAddresses()
        {
            ICollection<Address> addresses = await _context.Addresses.ToListAsync();
            ICollection<AddressDTO> dtos = _mapper.Map<ICollection<AddressDTO>>(addresses);

            return dtos;
        }
    }
}
