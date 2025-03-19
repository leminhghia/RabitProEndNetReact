using Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class ColorDto
    {
        public int ColorId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
