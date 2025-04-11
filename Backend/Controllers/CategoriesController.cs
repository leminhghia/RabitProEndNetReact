using Backend.DTOs;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var category = await _service.GetAllCategoriesAsync();

            return Ok(category);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto category)
        {
            var created = await _service.CreateCategoryAsync(category);

            return Ok(created);
        }
    }
}
