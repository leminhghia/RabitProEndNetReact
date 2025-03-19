using Backend.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class PriceDto
    {
        public int PriId { get; set; }
        public long Price { get; set; }
    }
}
