using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ProductSize>? ProductSizes { get; set; }
    }
}
