using Aledrogo.Data;
using Aledrogo.DTO;
using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly AledrogoContext _context;

        public UserRepository(SignInManager<User> signInManager, UserManager<User> userManager, AledrogoContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IdentityResult> ChangePassword(PasswordDTO dto)
        {
            if(dto.NewPassword == string.Empty || dto.OldPassword == string.Empty || dto.UserName == string.Empty)
            {
                IdentityError error = new IdentityError();
                error.Description = "Nazwa użytkownika, stare hasło lub nowe jest puste!";
                return IdentityResult.Failed(error);
            }

            User user = await _context.Users.FirstOrDefaultAsync(m => m.UserName == dto.UserName);
            IdentityResult result = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);

            return result;
        }

        public async Task ChangeRole(RoleDTO dto)
        {
            User user = await _context.Users.FirstOrDefaultAsync(m => m.UserName == dto.UserName);
            string oldRole = (await _userManager.GetRolesAsync(user))[0];

            await _userManager.RemoveFromRoleAsync(user, oldRole);
            await _userManager.AddToRoleAsync(user, dto.RoleName);
        }

        public async Task<ICollection<UserDTO>> GetAll()
        {
            List<UserDTO> dtos = new List<UserDTO>();
            ICollection<User> result = await _context.Users.ToListAsync();
            foreach(User user in result)
            {
                string roleName = (await _userManager.GetRolesAsync(user))[0];
                UserDTO dto = new UserDTO
                {
                    UserName = user.UserName,
                    Role = roleName
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<ICollection<UserDTO>> GetAllByName(string name)
        {
            List<UserDTO> dtos = new List<UserDTO>();
            ICollection<User> result = await _context.Users
                .Where(m => m.UserName.Contains(name)).ToListAsync();
            foreach (User user in result)
            {
                string roleName = (await _userManager.GetRolesAsync(user))[0];
                UserDTO dto = new UserDTO
                {
                    UserName = user.UserName,
                    Role = roleName
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<UserDTO> GetById(string id)
        {
            if(id == string.Empty)
            {
                return null;
            }

            User result = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            string idt = (await _context.Users.FirstOrDefaultAsync(m => m.UserName == "test3@wp.pl")).Id;

            if (result == null)
            {
                return null;
            }
            string roleName = (await _userManager.GetRolesAsync(result))[0];
            UserDTO dto = new UserDTO
            {
                UserName = result.UserName,
                Role = roleName
            };

            return dto;
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

        public async Task<IdentityResult> Register(RegistrationDTO dto, string roleName)
        {
            IdentityResult result = new IdentityResult();
            if (roleName == string.Empty)
            {
                IdentityError error = new IdentityError();
                error.Description = "Brak roli dla użytkownika";
                return IdentityResult.Failed(error);
            }
            else if (!String.Equals(dto.Password,dto.ConfirmPassword))
            {
                IdentityError error = new IdentityError();
                error.Description = "Hasla się nie zgadzają";
                return IdentityResult.Failed(error);
            }

            User newUser = new User
            {
                UserName = dto.UserName,
                Email = dto.UserName
            };

            result = await _userManager.CreateAsync(newUser, dto.Password);

            if(result.Succeeded)
            {
                await AddRoleToUser(newUser, roleName);
            }

            return result;
        }

        private async Task AddRoleToUser(User user, string roleName) => await _userManager.AddToRoleAsync(user, roleName);
    }
}
