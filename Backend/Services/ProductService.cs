using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<Product> CreateProductAsync(Product product)
        {
            return await _repository.AddAsync(product);
        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductListDto>> GetAllWithThumbnailAsync()
        {
            return await _repository.GetAllWithImageAsync();
        }
        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            return _repository.UpdateAsync(product);
        }
    }
}
