using Aledrogo.DTO;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public interface IUserRepository
    {
        Task<bool> LogIn(LogInDTO dto );
        Task<IdentityResult> Registration(RegistrationDTO dto, string roleName);
        Task LogOut();
        Task<UserDTO> GetById(string id);
        Task<ICollection<UserDTO>> GetAllByName(string name);
        Task<ICollection<UserDTO>> GetAll();
        Task<bool> ChangePassword(PasswordDTO dto);
        Task ChangeRole(RoleDTO dto);
    }
}
