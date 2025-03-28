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
            if (dto == null || string.IsNullOrEmpty(dto.TenSanPham))
            {
                return BadRequest("Dữ liệu không hợp lệ.");
            }


            var sanPham = new SanPham
            {
                TenSanPham = dto.TenSanPham,
                MoTa = dto.MoTa,
                GiaGoc = dto.GiaGoc,
                NgayTao = DateTime.UtcNow,
                NgaySua = DateTime.UtcNow,
                IsActived = dto.IsActived
            };

            context.SanPham.Add(sanPham);
            await context.SaveChangesAsync();


            if (dto.DanhMuc != null && dto.DanhMuc.Any())
            {
                var danhMucSanPhamList = dto.DanhMuc.Select(dm => new DanhMuc_SanPham
                {
                    SanPhamId = sanPham.SanPhamId,
                    DanhMucId = dm.DanhMucId
                }).ToList();

                context.DanhMuc_SanPham.AddRange(danhMucSanPhamList);
                await context.SaveChangesAsync(); // ✅ Lưu danh mục sản phẩm
            }


            if (dto.ThuongHieu != null && dto.ThuongHieu.Any())
            {
                var thuongHieuSanPhamList = dto.ThuongHieu.Select(th => new ThuongHieu_SanPham
                {
                    SanPhamId = sanPham.SanPhamId,
                    ThuongHieuId = th.ThuongHieuId
                }).ToList();

                context.ThuongHieu_SanPham.AddRange(thuongHieuSanPhamList);
                await context.SaveChangesAsync(); // ✅ Lưu thương hiệu sản phẩm
            }



            var sanPhamDto = new SanPhamDto
            {
                SanPhamId = sanPham.SanPhamId,
                TenSanPham = sanPham.TenSanPham,
                GiaGoc = sanPham.GiaGoc,
                NgayTao = sanPham.NgayTao,
                NgaySua = sanPham.NgaySua,
                IsActived = sanPham.IsActived,
                DanhMuc = dto.DanhMuc,
                ThuongHieu = dto.ThuongHieu,
            };

            return CreatedAtAction(nameof(GetById), new { id = sanPham.SanPhamId }, sanPhamDto);
        }


    }
}
