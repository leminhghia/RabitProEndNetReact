using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<ProductColor> ProductColors { get; set; }
    public DbSet<ProductSize> ProductSizes { get; set; }
    public DbSet<AgeGroup> AgeGroups { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<ProductImages> Images { get; set; }
    public DbSet<Size> Sizes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().ToTable("Brand");
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<Product>().ToTable("Product");
        modelBuilder.Entity<Color>().ToTable("Color");
        modelBuilder.Entity<ProductColor>().ToTable("ProductColor");
        modelBuilder.Entity<Size>().ToTable("Size");
        modelBuilder.Entity<AgeGroup>().ToTable("AgeGroup");
        modelBuilder.Entity<ProductSize>().ToTable("ProductSize");
        modelBuilder.Entity<Price>().ToTable("Price");
    }

}
