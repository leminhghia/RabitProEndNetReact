using System;

namespace Backend.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public long Price { get; set; }
    public int QuantityInStock { get; set; }

}
