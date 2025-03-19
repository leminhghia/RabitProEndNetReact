using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class ProductColor
    {
        [Key]
        public int ProColorId { get; set; }

        public int ProId { get; set; }
        [ForeignKey(nameof(ProId))]
        public Product? Product { get; set; }

        public int ColorId { get; set; }
        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; } = new();

        public int Quantity { get; set; }

        public List<Price>? Prices { get; set; }

        public int ProImgId { get; set; }
        [ForeignKey(nameof(ProImgId))]
        public ProductImages Images { get; set; } = new();
    }
}
