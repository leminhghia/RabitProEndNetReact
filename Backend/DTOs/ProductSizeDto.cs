using Backend.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class ProductSizeDto
    {
      

        public SizeDto Size { get; set; }

        public required string Gender { get; set; }

        public AgeGroupDto AgeGroup { get; set; }
    }
}
