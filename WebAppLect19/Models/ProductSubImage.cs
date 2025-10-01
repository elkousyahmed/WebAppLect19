using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace WebAppLect19.Models
{
    [PrimaryKey(nameof(ProductId), nameof(Img))]
    public class ProductSubImage
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null;
        public string Img { get; set; } = string.Empty;
    }
}
