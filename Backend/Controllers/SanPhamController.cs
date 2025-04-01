using Backend.Data;
using Backend.DTOs;
using Backend.Extensions;
using Backend.Models;
using Backend.Repositories;
using Backend.RequestHelpers;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    public class SanPhamController(SanPhamRepository sanPhamRepository, AppDbContext context) : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ProductParams productParams)
        {
            var thuongHieuIds = ChangeFormat(productParams.ThuongHieuId);
            var danhMucIds = ChangeFormat(productParams.DanhMucId);

            var query = context.SanPham
                .AsQueryable()
                .Sort(productParams.OrderBy,productParams.Sort)
                .Search(productParams.SearchItem)
                .Filter(thuongHieuIds, danhMucIds);

            var sanPham = await sanPhamRepository.GetAllSanPhamAsync(query,productParams.PageNumber, productParams.PageSize);

            Response.Headers["X-Pagination"] = System.Text.Json.JsonSerializer.Serialize(sanPham.MetaData);

            var response = new
            {
                metaData = sanPham.MetaData, 
                items = sanPham
            };

            return Ok(response);
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
                await context.SaveChangesAsync(); 
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
        private List<int> ChangeFormat(string? ids)
        {
            if (string.IsNullOrEmpty(ids)) return new List<int>();

            return ids.Split(',')
                      .Select(id => int.TryParse(id.Trim(), out var value) ? value : 0)
                      .Where(id => id != 0)
                      .ToList();
        }

    }
}
