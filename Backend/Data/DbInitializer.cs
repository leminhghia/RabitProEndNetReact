using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class DbInitializer
{
    public static async Task InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
        await SeedData(context);
    }

    public static async Task SeedData(StoreContext context)
    {
        if (await context.Products.AnyAsync()) return; // Nếu đã có dữ liệu, bỏ qua

        Console.WriteLine("Bắt đầu thêm dữ liệu...");

        var brands = new List<Brand>
    {
        new Brand { Name = "Nike", CreateAt = DateTime.UtcNow, CreateBy = 1 },
        new Brand { Name = "Adidas", CreateAt = DateTime.UtcNow, CreateBy = 1 }
    };
        await context.Brands.AddRangeAsync(brands);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Brands");

        var categories = new List<Category>
    {
        new Category { Name = "Shoes", CreateAt = DateTime.UtcNow, CreateBy = 1 },
        new Category { Name = "Clothing", CreateAt = DateTime.UtcNow, CreateBy = 1 }
    };
        await context.Categories.AddRangeAsync(categories);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Categories");

        var products = new List<Product>
    {
        new Product { Name = "Nike Air Max",Gender = "BOy",Description="123123", CatId = categories[0].CatId, BraId = brands[0].BraId, CreateAt = DateTime.UtcNow },
        new Product { Name = "Adidas Ultraboost",Gender="Girl",Description="51616612", CatId = categories[0].CatId, BraId = brands[1].BraId, CreateAt = DateTime.UtcNow }
    };
        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Products");

        var colors = new List<Color>
    {
        new Color { Name = "Red" },
        new Color { Name = "Blue" },
        new Color { Name = "Yellow" },
        new Color { Name = "Grreen" }
    };
        await context.Colors.AddRangeAsync(colors);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Colors");

        var productColors = new List<ProductColor>
    {
        new ProductColor { ProId = products[0].ProId,Quantity=10, ColorId = colors[0].ColorId },
        new ProductColor { ProId = products[1].ProId,Quantity=12, ColorId = colors[1].ColorId }
    };
        await context.ProductColors.AddRangeAsync(productColors);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm ProductColors");

        var productColorsFromDb = await context.ProductColors.ToListAsync();

        var prices = new List<Price>
    {
        new Price { ProColorId = productColorsFromDb[0].ProColorId, PriceValue = 19990  },
        new Price { ProColorId = productColorsFromDb[1].ProColorId, PriceValue = 17999 }
    };
        await context.Prices.AddRangeAsync(prices);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Prices");

        var images = new List<ProductImages>
        {
            new ProductImages {ImageUrl="anh 1"},
            new ProductImages {ImageUrl="anh 2"},
               new ProductImages {ImageUrl="anh 3"},
            new ProductImages {ImageUrl="anh 4"}
        };
        await context.Images.AddRangeAsync(images);
        await context.SaveChangesAsync();


        var sizes = new List<Size>
    {
        new Size { Name = "SM" },
        new Size { Name = "MD" },
    };
        await context.Sizes.AddRangeAsync(sizes);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm Sizes");

        var ageGroups = new List<AgeGroup>
    {
        new AgeGroup { Age = 1, MinWeight = 10, MaxWeight = 20, CreateAt = DateTime.UtcNow, CreateBy = 1 },
        new AgeGroup { Age = 2, MinWeight = 25, MaxWeight = 120, CreateAt = DateTime.UtcNow, CreateBy = 1 },
    };
        await context.AgeGroups.AddRangeAsync(ageGroups);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm AgeGroups");

        var productSizes = new List<ProductSize>
    {
        new ProductSize { ProId = products[0].ProId,Gender="BOY", SizeId = sizes[0].SizeId, AgeGroupId = ageGroups[0].AgeGroupId },
        new ProductSize { ProId = products[1].ProId, Gender="GIRL",SizeId = sizes[1].SizeId, AgeGroupId = ageGroups[1].AgeGroupId },
    };
        await context.ProductSizes.AddRangeAsync(productSizes);
        await context.SaveChangesAsync();
        Console.WriteLine("Đã thêm ProductSizes");

        Console.WriteLine(" SeedData hoàn tất!");
    }

}
