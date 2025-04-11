using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryDto dto)
        {
            var category = new Category
            {
                Id = dto.Id,
                CategoryName = dto.CategoryName,
                CategoryDescription = dto.CategoryDescription,
                Parent_id = dto.ParentId,
                ImagePath = dto.ImagePath,
                Active = dto.IsActived,
                CreatedAt = DateTime.UtcNow
            };  

            var result = await _repository.AddAsync(category);

            // Mapping ngược lại: Entity → Dto để return
            return new CategoryDto
            {
                Id = result.Id,
                CategoryName = result.CategoryName,
                CategoryDescription = result.CategoryDescription,
                ParentId = result.Parent_id,
                ImagePath = result.ImagePath,
                IsActived = result.Active
            };
        }


        public async Task<bool> DeleteCategoryAsync(Guid id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            return await _repository.GetAllCategory();
        }

        public async Task<Category?> GetCategoryByIdAsync(Guid id)
        {
            return await GetCategoryByIdAsync(id);
        }

        public Task<Category> UpdateCategoryAsync(Category category)
        {
           return _repository.UpdateAsync(category);
        }
    }
}
