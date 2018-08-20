using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Aledrogo.Data
{
    public static class SeedData
    {
        private static AledrogoContext _context;
        private static UserManager<User> _userManager;
        private static RoleManager<IdentityRole> _roleManager;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AledrogoContext>();
            _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            Seed().Wait();
        }

        private static async Task Seed()
        {
            foreach(var role in DataToSeed.Roles)
            {
                await SeedRole(role);
            }

            foreach (var user in DataToSeed.Users)
            {
                await SeedUser(user);
            }

            foreach (var category in DataToSeed.Categories)
            {
                await SeedCategory(category);
            }
        }

        private static async Task SeedRole(string roleName)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
                await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
        }

        private static async Task SeedUser(DataToSeed.User user)
        {
            if (await _userManager.FindByNameAsync(user.UserName) == null)
            {
                User newUser = new User { UserName = user.UserName, Email = user.Email };
                await _userManager.CreateAsync(newUser, user.Password);
                await _userManager.AddToRoleAsync(newUser, user.RoleName);
            }
        }

        private static async Task SeedCategory(Category category)
        {
            if (_context.Categories.Where(c => c.Name == category.Name).FirstOrDefault() == null)
            {
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
