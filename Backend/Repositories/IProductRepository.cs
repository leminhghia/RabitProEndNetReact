using Backend.DTOs;
using Backend.Models;

namespace Backend.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid id);
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<bool> DeleteAsync(Guid id);

        Task<IEnumerable<ProductListDto>> GetAllWithImageAsync();
    }
}
