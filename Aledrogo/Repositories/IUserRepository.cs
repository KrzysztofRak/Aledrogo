using Aledrogo.DTO;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public interface IUserRepository
    {
        Task<bool> LogIn(LogInDTO dto );
        Task<IdentityResult> Registration(RegistrationDTO dto, string roleName);
        Task LogOut();
    }
}
