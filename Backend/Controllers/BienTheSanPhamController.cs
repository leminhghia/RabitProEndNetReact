using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class BienTheSanPhamController(SanPhamBienTheRepository sanPhamBienTheRepository, AppDbContext context) : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sanPhamBT = await sanPhamBienTheRepository.GetAllSanPhamBTAsync();
            return Ok(sanPhamBT);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sanPhamBT = await sanPhamBienTheRepository.GetByIdAsync(id);
            return Ok(sanPhamBT);
        }
        [HttpPost]
        public async Task<IActionResult> AddBienThe([FromForm] BienTheSanPhamDto dto, List<IFormFile>? hinhAnh)
        {
            if (dto == null) return BadRequest("Dữ liệu không hợp lệ");
            var bienThe = new BienTheSanPham
            {
                SanPhamId = dto.SanPhamId,
                Size = dto.Size,
                MauSac = dto.MauSac,
                GiaBan = dto.GiaBan,
                SoLuong = dto.SoLuong,
                NgayTao = DateTime.UtcNow,
                IsActived = true,
            };

            context.BienTheSanPham.Add(bienThe);
            await context.SaveChangesAsync();

            if (hinhAnh != null && hinhAnh.Count > 0)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }
                foreach (var file in hinhAnh)
                {
                    var fileName = $"{Guid.NewGuid()}_{file.FileName}";
                    var filePath = Path.Combine(uploads, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var hinhAnhEntity = new HinhAnhSanPham
                    {
                        BienTheId = bienThe.BienTheId,
                        URLHinhAnh = $"/uploads/{fileName}",
                        NgayTao = DateTime.UtcNow
                    };

                    context.HinhAnhSanPham.Add(hinhAnhEntity);
                }
                await context.SaveChangesAsync();
            }
            return Ok(new { Message = "Thêm sản phẩm thành công!" });

        }

    }
}



