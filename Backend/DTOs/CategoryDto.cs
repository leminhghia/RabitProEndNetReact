namespace Backend.DTOs
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public  required string CategoryName { get; set; }
        public string? CategoryDescription{ get; set; }
        public bool IsActived { get; set; }
        public List<CategoryDto> Children { get; set; } = new();

    }
}
