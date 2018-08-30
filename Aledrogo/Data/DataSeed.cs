using Aledrogo.Data.DataToSeed;
using Aledrogo.Data.DataToSeed.DTO;
using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;

namespace Aledrogo.Data
{
    public static class DataSeed
    {
        private static AledrogoContext _context;
        private static UserManager<User> _userManager;
        private static RoleManager<IdentityRole> _roleManager;

        public static void Initialize(AledrogoContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            SeedAll();
        }

        private static void SeedAll()
        {
            SeedRoles(new RoleSeed());
            SeedUsers(new UserSeed());
            SeedData(new AddressSeed());
            SeedData(new BasketSeed());
            SeedData(new CategorySeed());
            SeedData(new DeliveryMethodTypeSeed());
            SeedData(new DeliveryMethodSeed());
            SeedData(new ImageSeed());
            SeedData(new OfferSeed());
            SeedData(new OrderSeed());
            SeedData(new ProductStateSeed());
            SeedData(new ProductSeed());
            SeedData(new Product_DeliveryMethodSeed());
            SeedData(new Product_SpecificFieldValueSeed());
            SeedData(new SpecificFieldSeed());
            SeedData(new SpecificFieldValueSeed());
            SeedData(new TransactionRatingSeed());
            SeedData(new TransactionRatingResponseSeed());

            _context.SaveChanges();
        }

        private static void SeedRoles(IDataToSeed rolesToSeed)
        {
            foreach (string roleName in rolesToSeed.Items)
            {
                _roleManager.CreateAsync(new IdentityRole { Name = roleName }).Wait();
            }
        }

        private static void SeedUsers(IDataToSeed usersToSeed)
        {

            foreach (UserSeedDTO user in usersToSeed.Items)
            {
                User newUser = new User { UserName = user.UserName, Email = user.Email };
                _userManager.CreateAsync(newUser, user.Password).Wait();
                user.Id = newUser.Id;
                _userManager.AddToRoleAsync(newUser, user.RoleName).Wait();
            }
        }

        private static void SeedData(IDataToSeed dataToSeed)
        {
            foreach (object item in dataToSeed.Items)
            {
                _context.Add(item);
            }
        }
    }
}
