using Backend.Data;
using Backend.Models;
using Backend.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<SanPhamRepository>();
builder.Services.AddScoped<DanhMucRepository>();
builder.Services.AddScoped<ThuongHieuRepository>();
builder.Services.AddScoped<SanPhamBienTheRepository>();
builder.Services.AddScoped<HinhAnhSanPham>();
builder.Services.AddCors(); 
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("https://localhost:3001");
});

app.MapControllers();
app.UseStaticFiles();


app.Run();
