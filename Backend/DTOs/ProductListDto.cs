using Backend.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend.DTOs
{
    public class ProductListDto
    {
        public Guid Id   { get; set; }
        public required string Name { get; set; }
        public string? BrandName { get; set; }
        public float regular_price { get; set; }
        public float? DiscountPrice { get; set; }
        public required string Gender { get; set; }
        
        public bool IsFlashSale { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<FlashSale>?  FlashSale { get; set; }

        public List<Gallery>? Images { get; set; } = new();

    }
}
