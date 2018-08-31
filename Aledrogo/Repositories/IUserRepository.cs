using Aledrogo.DTO;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public interface IUserRepository
    {
        Task<bool> LogIn(LogInDTO dto );
        Task<IdentityResult> Register(RegistrationDTO dto, string roleName);
        Task LogOut();
        Task<UserDTO> GetById(string id);
        Task<ICollection<UserDTO>> GetAllByName(string name);
        Task<ICollection<UserDTO>> GetAll();
        Task<IdentityResult> ChangePassword(PasswordDTO dto);
        Task ChangeRole(RoleDTO dto);
        Task<bool> RemoveUser(string userName);
    }
}
