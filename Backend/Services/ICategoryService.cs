using Backend.DTOs;
using Backend.Models;

namespace Backend.Services
{
    public interface ICategoryService
    {
        Task<Category?> GetCategoryByIdAsync(Guid id);
        Task<CategoryDto> CreateCategoryAsync(CategoryDto category);
        Task<CategoryDto?> UpdateCategoryAsync(CategoryDto dto);
        Task<bool> DeleteCategoryAsync(Guid id);
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
    }
}
