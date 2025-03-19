using Backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
}
