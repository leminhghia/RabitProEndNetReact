using Backend.DTOs;
using Backend.Models;

namespace Backend.Services
{
    public interface IProductService
    {
        Task<Product?> GetProductByIdAsync(Guid id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid id);
        Task<IEnumerable<ProductListDto>> GetAllWithThumbnailAsync();
    }
}
