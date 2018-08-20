using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Aledrogo.Data.DataToSeed;

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
            foreach(var role in RoleSeed.Roles)
            {
                await SeedRole(role);
            }

            foreach (var user in UserSeed.Users)
            {
                await SeedUser(user);
            }

            foreach (var category in CategorySeed.Categories)
            {
                await SeedCategory(category);
            }

            foreach (var categoryField in CategoryFieldSeed.CategoryFields)
            {
                await SeedCategoryField(categoryField);
            }

            foreach (var predefinedValueForCategoryField in PredefinedValueForCategoryFieldSeed.PredefinedValuesForCategoryFields)
            {
                await SeedPredefinedValueForCategoryField(predefinedValueForCategoryField);
            }

            foreach (var product in ProductSeed.Products)
            {
                await SeedProduct(product);
            }
        }

        private static async Task SeedRole(string roleName)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
                await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
        }

        private static async Task SeedUser(UserSeed user)
        {
            if (await _userManager.FindByNameAsync(user.UserName) == null)
            {
                User newUser = new User { UserName = user.UserName, Email = user.Email };
                await _userManager.CreateAsync(newUser, user.Password);
                user.Id = newUser.Id;
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

        private static async Task SeedCategoryField(CategoryField categoryField)
        {
            if (_context.Categories.Where(f => f.Name == f.Name).FirstOrDefault() == null)
            {
                await _context.AddAsync(categoryField);
                await _context.SaveChangesAsync();
            }
        }

        private static async Task SeedPredefinedValueForCategoryField(PredefinedValueForCategoryField predefinedValueForCategoryField)
        {
            if (_context.PredefinedValuesForCategoryFields.Where(v => v.Value == v.Value).FirstOrDefault() == null)
            {
                await _context.PredefinedValuesForCategoryFields.AddAsync(predefinedValueForCategoryField);
                await _context.SaveChangesAsync();
            }
        }

        private static async Task SeedProduct(Product product)
        {
            if (_context.Products.Where(p => p.Name == product.Name).FirstOrDefault() == null)
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
