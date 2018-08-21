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

            foreach (var specificField in SpecificFieldSeed.SpecificFields)
            {
                await SeedSpecificField(specificField);
            }

            foreach (var specificFieldValue in SpecificFieldValueSeed.SpecificFieldsValues)
            {
                await SeedSpecificFieldValue(specificFieldValue);
            }

            foreach (var product in ProductSeed.Products)
                await SeedProduct(product);

            foreach (var image in ImageSeed.Images)
            {
                await SeedImage(image);
            }

            foreach (var product_SpecificFieldValue in Product_SpecificFieldValueSeed.Products_SpecificFieldValues)
            {
                await SeedProduct_SpecificFieldValue(product_SpecificFieldValue);
            }

            await _context.SaveChangesAsync();
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
            }
        }

        private static async Task SeedSpecificField(SpecificField specificField)
        {
            if (_context.SpecificFields.Where(f => f.Name == specificField.Name).FirstOrDefault() == null)
            {
                await _context.SpecificFields.AddAsync(specificField);
            }
        }

        private static async Task SeedSpecificFieldValue(SpecificFieldValue specificFieldValue)
        {
            if (_context.SpecificFieldValues.Where(s => s.Value == specificFieldValue.Value && s.SpecificField == specificFieldValue.SpecificField).FirstOrDefault() == null)
            {
                await _context.SpecificFieldValues.AddAsync(specificFieldValue);
            }
        }

        private static async Task SeedProduct(Product product)
        {
            if (_context.Products.Where(p => p.Name == product.Name).FirstOrDefault() == null)
            {
                await _context.Products.AddAsync(product);
            }
        }

        private static async Task SeedImage(Image image)
        {
            if (_context.Images.Where(i => i.ImagePath == image.ImagePath && i.Product == image.Product).FirstOrDefault() == null)
            {
                await _context.Images.AddAsync(image);
            }
        }

        private static async Task SeedProduct_SpecificFieldValue(Product_SpecificFieldValue product_SpecificFieldValue)
        {
            if (_context.Product_SpecificFieldValues.Where(p => p.Product == product_SpecificFieldValue.Product && p.SpecificFieldValue == product_SpecificFieldValue.SpecificFieldValue).FirstOrDefault() == null)
            {
                await _context.Product_SpecificFieldValues.AddAsync(product_SpecificFieldValue);
            }
        }
    }
}
