using Backend.Data;
using Backend.DTOs;
using Backend.Extensions;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{

    public class ProductsController(StoreContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await GetTheProducts();
            if (products == null) return NoContent();
            return products.Select(p => p.ToDto()).ToList();


        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await GetTheProduct(id);
            if (product == null) return NoContent();
            return product.ToDto();
        }

        private async Task<List<Product>> GetTheProducts()
        {
            return await context.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.ProductSizes)
                    .ThenInclude(x => x.AgeGroup)
                .Include(x => x.ProductSizes)
                    .ThenInclude(x => x.Size)
                .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Prices)
                .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Color)
                .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Images)
                .ToListAsync(); 
        }

        private async Task<Product?> GetTheProduct(int id )
        {
            return await context.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Include(x => x.ProductSizes)
                    .ThenInclude(x => x.AgeGroup)
                .Include(x => x.ProductSizes)
                    .ThenInclude(x => x.Size)
                .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Prices)
                .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Color)
                    .Include(x => x.ProductColors)
                    .ThenInclude(x => x.Images)
                .FirstOrDefaultAsync(p => p.ProId == id); 
        }

    }
}
