using Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class CategoryDto
    {

        public int CatId { get; set; }
        public string? Name { get; set; }

       
    }
}
