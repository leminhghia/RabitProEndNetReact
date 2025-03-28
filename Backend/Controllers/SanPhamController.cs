using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    public class SanPhamController(SanPhamRepository sanPhamRepository, AppDbContext context) : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sanPham = await sanPhamRepository.GetAllSanPhamAsync();
            return Ok(sanPham);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sanPham = await sanPhamRepository.GetById(id);
            return Ok(sanPham);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SanPhamDto dto)
        {
          
         
            var sanPham = new SanPham
            {
                TenSanPham = dto.TenSanPham,
                MoTa = dto.MoTa,
                GiaGoc = dto.GiaGoc,
                NgayTao = DateTime.UtcNow,
                DanhMucId = dto.DanhMucId,
                ThuongHieuId = dto.ThuongHieuId,
                NgaySua = DateTime.UtcNow,
                IsActived = dto.IsActived,
            };

        
            await sanPhamRepository.AddAsync(sanPham);
           
            return CreatedAtAction(nameof(GetById), new { id = sanPham.SanPhamId }, sanPham);

          

        }
    }
}
