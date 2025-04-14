using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class ProducRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProducRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> AddAsync(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null) return false;

            _context.Product.Remove(product);
            return true;
        }

        public async Task<IEnumerable<ProductListDto>> GetAllWithImageAsync()
        {
            var products = await _context.Product
                                       .Include(x => x.Galleries)
              .Include(x => x.Brand)
              .Select(x => new ProductListDto
              {
                  Id = x.Id,
                  Name = x.ProductName,
                  BrandName = x.Brand != null ? x.Brand.BrandName : null,
                  regular_price = x.RegularPrice ?? 0,
                  DiscountPrice = x.DiscountPrice,
                  Gender = x.Gender,
                  IsFlashSale = x.IsFlashSale,
                  FlashSale = x.IsFlashSale ?
                  x.FlashSale!
                  .Select(f => new FlashSale
                  {
                      StartTime = f.StartTime,
                      EndTime = f.EndTime,
                      MaxQuantity = f.MaxQuantity,

                  }).ToList()
                  : null,
                  Images = x.Galleries!
                .OrderBy(g => g.DisplayOrder)
                .Select(g => new Gallery
                {
                    Id = g.Id,
                    ImagePath = g.ImagePath,
                    DisplayOrder = g.DisplayOrder
                }).ToList()
              })
                .ToListAsync();
            return products;
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _context.Product.FindAsync(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {

            _context.Product.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
