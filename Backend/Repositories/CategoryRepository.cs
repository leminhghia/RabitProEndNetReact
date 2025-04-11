using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Category> AddAsync(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }


        public async Task<bool> DeleteAsync(Guid id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null) return false;

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<IEnumerable<CategoryDto>> GetAllCategory()
        {
            var categories = await _context.Category
                .Select(x => new CategoryDto
                {
                    Id = x.Id,
                    CategoryName = x.CategoryName,
                    ParentId = x.Parent_id,
                    IsActived = x.Active
                }).ToListAsync();
            var categoryDict = categories.ToDictionary(x => x.Id);

            List<CategoryDto> tree = new();

            foreach (var category in categories)
            {
                if (category.ParentId == null)
                {
                    tree.Add(category);               
                }
                else if (categoryDict.TryGetValue(category.ParentId!.Value , out var parent))
                {
                    parent.Children.Add(category);
                }
            }
            return tree;
        }

        public async Task<Category?> GetByIdAsync(Guid id)
        {

            return await _context.Category.FindAsync(id);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
           _context.Category.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
