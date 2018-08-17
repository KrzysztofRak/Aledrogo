using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Aledrogo.Data
{
    public static class SeedData
    {
        private static ModelBuilder _builder;
        private static UserManager<User> _userManager;
        private static RoleManager<IdentityRole> _roleManager;

        public static void Initialize(ModelBuilder builder)
        {
            _builder = builder;
         //   _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
          //  _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            // First, Creating User role as each role in User Manager  

            Seed().Wait();
        }

        private static async Task Seed()
        {
            await SeedRole("Admin");
            await SeedRole("User");

            await SeedUser("admin@wp.pl", "admin", "Admin");
            await SeedUser("artur@wp.pl", "artur", "User");
            await SeedUser("krzysztof@wp.pl", "krzysztof", "User");

            SeedCategories();
        }

        private static async Task SeedRole(string roleName)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
                await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
        }

        private static async Task SeedUser(string userName, string password, string roleName)
        {
            if (await _userManager.FindByNameAsync(userName) == null)
            {
                User newUser = new User { UserName = userName, Email = userName, SecurityStamp = "215236264252" };
                await _userManager.CreateAsync(newUser, password);
                await _userManager.AddToRoleAsync(newUser, roleName);
            }
        }

        private static void SeedCategories()
        {
            _builder.Entity<Category>().HasData(new Category() { Id = 1, Name = "Elektornika" },

            new Category() { Id = 2, Name = "RTV i AGD", ParentCategoryId = 1 },
            new Category() { Id = 3, Name = "Pralki", ParentCategoryId = 2 },
            new Category() { Id = 4, Name = "Telewizory", ParentCategoryId = 2 },

            new Category() { Id = 5, Name = "Telefony i akcesoria", ParentCategoryId = 1 },
            new Category() { Id = 6, Name = "Xiaomi", ParentCategoryId = 5 },
            new Category() { Id = 7, Name = "Powerbanki", ParentCategoryId = 5 },


            new Category() { Id = 8, Name = "Moda" },

            new Category() { Id = 9, Name = "Odzież, obuwie, dodatki", ParentCategoryId = 8 },
            new Category() { Id = 10, Name = "Sukienki", ParentCategoryId = 9 },
            new Category() { Id = 11, Name = "Walizki", ParentCategoryId = 9 },

            new Category() { Id = 12, Name = "Biżuteria i zegarki", ParentCategoryId = 8 },
            new Category() { Id = 13, Name = "Naszyjniki", ParentCategoryId = 12 },
            new Category() { Id = 14, Name = "Zegarki męskie", ParentCategoryId = 12 });
        }
    }
}
