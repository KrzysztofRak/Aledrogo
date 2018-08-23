using Aledrogo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Aledrogo.Data
{
    public class AledrogoContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<Product_DeliveryMethod> Products_DeliveryMethods { get; set; }
        public DbSet<TransactionRating> TransactionRatings { get; set; }
        public DbSet<TransactionRatingResponse> TransactionRatingResponses { get; set; }
        public DbSet<SpecificField> SpecificFields { get; set; }
        public DbSet<SpecificFieldValue> SpecificFieldValues { get; set; }
        public DbSet<Product_SpecificFieldValue> Products_SpecificFieldValues { get; set; }


        public AledrogoContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Basket>().ToTable("Basket");
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Image>().ToTable("Image");
            builder.Entity<Offer>().ToTable("Offer");
            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<DeliveryMethod>().ToTable("DeliveryMethod");
            builder.Entity<Product_DeliveryMethod>().ToTable("Product_DeliveryMethod");
            builder.Entity<TransactionRating>().ToTable("TransactionRating");
            builder.Entity<TransactionRatingResponse>().ToTable("TransactionRatingResponse");
            builder.Entity<SpecificField>().ToTable("SpecificField");
            builder.Entity<SpecificFieldValue>().ToTable("SpecificFieldValue");
            builder.Entity<Product_SpecificFieldValue>().ToTable("Product_SpecificFieldValue");

            foreach(var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(builder);
        }
    }
}
