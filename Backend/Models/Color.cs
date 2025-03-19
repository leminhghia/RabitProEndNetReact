using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ProductColor>? ProductColors { get; set; } 
    }

}
