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
               Active = dto.IsActived,
                CreatedAt = DateTime.UtcNow
            };  

            var result = await _repository.AddAsync(category);

            return new CategoryDto
            {
                Id = result.Id,
                CategoryName = result.CategoryName,
                CategoryDescription = result.CategoryDescription,
                ParentId = result.Parent_id,
                IsActived = result.Active
            };
        }


        public async Task<bool> DeleteCategoryAsync(Guid id)
        {
            var category = await _repository.GetByIdAsync(id);
            if (category == null) return false;

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

        public async Task<CategoryDto?> UpdateCategoryAsync(CategoryDto dto)
        {
            var existing = await _repository.GetByIdAsync(dto.Id);
            if (existing == null) return null;

            existing.CategoryName = dto.CategoryName;
            existing.CategoryDescription = dto.CategoryDescription;
            existing.Parent_id = dto.ParentId;
            existing.Active = dto.IsActived;

            var updated = await _repository.UpdateAsync(existing);

            return new CategoryDto
            {
                Id = updated.Id,
                CategoryName = updated.CategoryName,
                CategoryDescription = updated.CategoryDescription,
                ParentId = updated.Parent_id,
                IsActived = updated.Active
            };

        }
    }
}
