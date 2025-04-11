using Backend.Data;
using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContext<AppDbContext>(opt =>
{
	opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<SanPhamRepository>();
builder.Services.AddScoped<DanhMucRepository>();
builder.Services.AddScoped<ThuongHieuRepository>();
builder.Services.AddScoped<SanPhamBienTheRepository>();
builder.Services.AddScoped<HinhAnhSanPham>();
builder.Services.AddIdentityApiEndpoints<User>(opt =>
{
	opt.User.RequireUniqueEmail = true;

})
		.AddRoles<IdentityRole>()
		.AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(opt =>
{
	opt.WithOrigins("https://localhost:3000")  // Cung cấp địa chỉ của frontend
		 .AllowAnyHeader()
		 .AllowAnyMethod()
		 .AllowCredentials();  // Cho phép gửi cookies và credentials
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGroup("api").MapIdentityApi<User>();
app.UseStaticFiles();
// "DefaultConnection": "Data Source=mydatabase.db"

app.Run();
