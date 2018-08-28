using Aledrogo.Data.DataToSeed;
using Aledrogo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Aledrogo.Data
{
    public static class SeedData
    {
        private static AledrogoContext _context;
        private static UserManager<User> _userManager;
        private static RoleManager<IdentityRole> _roleManager;

        public static async Task Initialize(AledrogoContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

            await _context.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();

            await SeedAll();
        }

        private static async Task SeedAll()
        {
            await SeedRoles();
            await SeedUsers();
            await SeedAddresses();
            await SeedBaskets();
            await SeedCategories();
            await SeedDeliveryMethodTypes();
            await SeedDeliveryMethods();
            await SeedImages();
            await SeedOffers();
            await SeedOrders();
            await SeedProducts();
            await SeedProducts_DeliveryMethods();
            await SeedProducts_SpecificFieldValues();
            await SeedSpecificFields();
            await SeedSpecificFieldValues();
            await SeedTransactionRatings();
            await SeedTransactionRatingsResponses();

            await _context.SaveChangesAsync();
        }

        private static async Task SeedRoles()
        {
            foreach (var roleName in RoleSeed.RoleNames)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
            }
        }

        private static async Task SeedUsers()
        {

            foreach (var user in UserSeed.Users)
            {
                User newUser = new User { UserName = user.UserName, Email = user.Email };
                await _userManager.CreateAsync(newUser, user.Password);
                user.Id = newUser.Id;
                await _userManager.AddToRoleAsync(newUser, user.RoleName);
            }
        }

        private static async Task SeedAddresses()
        {
            foreach (var address in AddressSeed.Addresses)
            {
                await _context.Addresses.AddAsync(address);
            }
        }

        private static async Task SeedBaskets()
        {
            foreach (var basket in BasketSeed.Baskets)
            {
                await _context.Baskets.AddAsync(basket);
            }
        }

        private static async Task SeedCategories()
        {
            foreach (var category in CategorySeed.Categories)
            {
                await _context.Categories.AddAsync(category);
            }
        }

        private static async Task SeedDeliveryMethodTypes()
        {
            foreach (var deliveryMethodType in DeliveryMethodTypeSeed.DeliveryMethodTypes)
            {
                await _context.DeliveryMethodTypes.AddAsync(deliveryMethodType);
            }
        }

        private static async Task SeedDeliveryMethods()
        {
            foreach (var deliveryMethod in DeliveryMethodSeed.DeliveryMethods)
            {
                await _context.DeliveryMethods.AddAsync(deliveryMethod);
            }
        }

        private static async Task SeedImages()
        {
            foreach (var image in ImageSeed.Images)
            {
                await _context.Images.AddAsync(image);
            }
        }

        private static async Task SeedOffers()
        {
            foreach (var offer in OfferSeed.Offers)
            {
                await _context.Offers.AddAsync(offer);
            }
        }

        private static async Task SeedOrders()
        {
            foreach (var order in OrderSeed.Orders)
            {
                await _context.Orders.AddAsync(order);
            }
        }

        private static async Task SeedProducts()
        {
            foreach (var product in ProductSeed.Products)
            {
                await _context.Products.AddAsync(product);
            }
        }

        private static async Task SeedProducts_DeliveryMethods()
        {
            foreach (var productDeliveryMethod in Product_DeliveryMethodSeed.Products_DeliveryMethods)
            {
                await _context.Products_DeliveryMethods.AddAsync(productDeliveryMethod);
            }
        }

        private static async Task SeedProducts_SpecificFieldValues()
        {

            foreach (var product_SpecificFieldValue in Product_SpecificFieldValueSeed.Products_SpecificFieldValues)
            {
                await _context.Products_SpecificFieldValues.AddAsync(product_SpecificFieldValue);
            }
        }

        private static async Task SeedSpecificFields()
        {
            foreach (var specificField in SpecificFieldSeed.SpecificFields)
            {
                await _context.SpecificFields.AddAsync(specificField);
            }
        }

        private static async Task SeedSpecificFieldValues()
        {
            foreach (var specificFieldValue in SpecificFieldValueSeed.SpecificFieldsValues)
            {
                await _context.SpecificFieldValues.AddAsync(specificFieldValue);
            }
        }

        private static async Task SeedTransactionRatings()
        {
            foreach (var transactionRating in TransactionRatingSeed.TransactionRatings)
            {
                await _context.TransactionRatings.AddAsync(transactionRating);
            }
        }

        private static async Task SeedTransactionRatingsResponses()
        {
            foreach (var transactionRatingResponse in TransactionRatingResponseSeed.TransactionRatingResponses)
            {
                await _context.TransactionRatingResponses.AddAsync(transactionRatingResponse);
            }
        }
    }
}
