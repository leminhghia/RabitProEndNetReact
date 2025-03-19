using Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class BrandDto
    {
        public int BraId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
