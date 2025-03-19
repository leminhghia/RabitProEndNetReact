using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class SizeDto
    {
        public int SizeId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
