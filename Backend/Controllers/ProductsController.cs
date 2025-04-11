using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllWithThumbnailAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var products = await _service.GetProductByIdAsync(id);
            if (products == null) return NotFound();
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var created = await _service.CreateProductAsync(product);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id,Product product)
        {
            if (id != product.Id) return BadRequest("Id not found");
            var updated = await _service.UpdateProductAsync(product);
            return Ok(updated);
        }
    }
}
