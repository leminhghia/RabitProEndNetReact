using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Attribute = Backend.Models.Attribute;

namespace Backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<AttributeValues> AttributeValues { get; set; }

        public DbSet<ProductAttribute> ProductAttribute { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<Variant> Variant { get; set; }
        public DbSet<VariantValue> VariantValue { get; set; }
        public DbSet<VariantAttributeValue> VariantAttributeValue { get; set; }

        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<ProductShipping> ProductShipping { get; set; }




        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductShipping>().ToTable("Product_shipping");
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<ProductCategory>().ToTable("Product_categories");
            builder.Entity<Brand>().ToTable("Brand");
            builder.Entity<Gallery>().ToTable("Galleries");
            builder.Entity<Attribute>().ToTable("Attributes");
            builder.Entity<AttributeValues>().ToTable("Attribute_values");
            builder.Entity<ProductAttribute>().ToTable("Product_attribute");
            builder.Entity<Tag>().ToTable("Tags");
            builder.Entity<ProductTag>().ToTable("Product_tags");
            builder.Entity<Variant>().ToTable("Variants");
            builder.Entity<VariantValue>().ToTable("Variant_value");
            builder.Entity<VariantAttributeValue>().ToTable("Variant_attribute_value");
            builder.Entity<Shipping>().ToTable("Shippings");

            builder.Entity<Variant>()
    .HasOne(v => v.VariantValue)
    .WithOne(vv => vv.Variant)
    .HasForeignKey<VariantValue>(vv => vv.Variant_id);

            builder.Entity<IdentityRole>()
      .HasData(
          new IdentityRole { Id = "683ef5e6-a3c9-4be0-bded-0b64256e9f0a", Name = "Member", NormalizedName = "MEMBER" },
          new IdentityRole { Id = "7afca44c-517f-4632-b41e-cc774c90d0b4", Name = "Admin", NormalizedName = "ADMIN" }
      );
        }


    }
}
