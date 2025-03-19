using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class AgeGroupDto
    {
        public int AgeGroupId { get; set; }
        public int Age { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
    }
}
