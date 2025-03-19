using Backend.DTOs;
using Backend.Models;

namespace Backend.Extensions
{
    public static class ProductExtension
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto
            {
                ProId = product.ProId,
                Name = product.Name,
                Description = product.Description,
                Gender = product.Gender, 

                Category = product.Category != null
                    ? new CategoryDto { CatId = product.Category.CatId, Name = product.Category.Name }
                    : null,

                Brand = product.Brand != null
                    ? new BrandDto { BraId = product.Brand.BraId, Name = product.Brand.Name }
                    : null,

                ProductSizes = product.ProductSizes?.Select(x => new ProductSizeDto
                {
                    Size = new SizeDto
                    {
                        SizeId = x.SizeId,
                        Name = x.Size.Name
                    },
                    Gender = x.Gender, 
                    AgeGroup = new AgeGroupDto
                    {
                        AgeGroupId = x.AgeGroupId,
                        Age = x.AgeGroup.Age,
                        MinWeight = x.AgeGroup.MinWeight,
                        MaxWeight = x.AgeGroup.MaxWeight
                    }
                }).ToList() ?? new List<ProductSizeDto>(),

                ProductColors = product.ProductColors?.Select(x => new ProductColorDto
                {

                    Color = new ColorDto
                    {
                        ColorId = x.ColorId,
                        Name = x.Color.Name,
                    },
                    Quantity=x.Quantity,
                    Images = x.Images != null
        ? new ProductImagesDto
        {
                     
            ProImgId = x.Images.ProImgId,
            ImageUrl = x.Images.ImageUrl,

        }
        : null,

                    Prices = x.Prices != null && x.Prices.Any()
        ? new PriceDto
        {
            PriId = x.Prices.First().PriId,
            Price = x.Prices.First().PriceValue
        }
        : null

                }).ToList() ?? new List<ProductColorDto>(),
            };
        }
    }
}
