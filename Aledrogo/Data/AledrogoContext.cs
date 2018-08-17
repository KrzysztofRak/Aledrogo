using Aledrogo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aledrogo.Data
{
    public class AledrogoContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySpecificField> CategorySpecificFields { get; set; }
        public DbSet<CategorySpecificFieldValue> CategorySpecificFieldValues { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }
        public DbSet<TransactionRating> TransactionRatings { get; set; }
        public DbSet<TransactionRatingResponse> TransactionRatingResponses { get; set; }


        public AledrogoContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Basket>().ToTable("Basket");
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<CategorySpecificField>().ToTable("CategorySpecificField");
            builder.Entity<CategorySpecificFieldValue>().ToTable("CategorySpecificFieldValue");
            builder.Entity<DeliveryMethod>().ToTable("DeliveryMethod");
            builder.Entity<Image>().ToTable("Image");
            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<ProductDeliveryMethod>().ToTable("ProductDeliveryMethod");
            builder.Entity<TransactionRating>().ToTable("TransactionRating");
            builder.Entity<TransactionRatingResponse>().ToTable("TransactionRatingResponse");    
        }
    }
}
