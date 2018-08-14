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
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOpinion> ProductOpinions { get; set; }

        public AledrogoContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Basket>().ToTable("Basket");
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<CategorySpecificField>().ToTable("CategorySpecificField");
            builder.Entity<CategorySpecificFieldValue>().ToTable("CategorySpecificFieldValue");
            builder.Entity<Image>().ToTable("Image");
            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<ProductOpinion>().ToTable("ProductOpinion");

            base.OnModelCreating(builder);
        }
    }
}
