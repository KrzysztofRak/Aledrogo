using Aledrogo.Data;
using Aledrogo.DTO;
using Aledrogo.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly AledrogoContext _context;
        public UserRepository(IMapper mapper, SignInManager<User> signInManager, UserManager<User> userManager, AledrogoContext context)
        {
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<bool> LogIn(LogInDTO dto)
        {
            var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, dto.isPersistent, false);

            return result.Succeeded;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Registration(RegistrationDTO dto, string roleName)
        {
            User newUser = new User
            {
                UserName = dto.UserName,
                Email = dto.UserName
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, dto.Password);

            if(result.Succeeded)
            {
                await AddRoleToUser(newUser, roleName);
            }

            return result;
        }

        private async Task AddRoleToUser(User user, string roleName) => await _userManager.AddToRoleAsync(user, roleName);
    }
}
