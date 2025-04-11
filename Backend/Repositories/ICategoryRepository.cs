using Backend.DTOs;
using Backend.Models;

namespace Backend.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryDto>> GetAllCategory();
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<bool> DeleteAsync(Guid id);
        Task<Category?> GetByIdAsync(Guid id);
       
    }
 
    
}
