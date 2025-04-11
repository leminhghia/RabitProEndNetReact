namespace Backend.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public  required string CategoryName { get; set; }
        public string? CategoryDescription{ get; set; }
        public string? ImagePath { get; set; }
        public bool IsActived { get; set; }
        public List<CategoryDto> Children { get; set; } = new();

    }
}
