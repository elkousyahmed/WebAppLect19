  using Microsoft.EntityFrameworkCore;

namespace WebAppLect19.Models
{
    [PrimaryKey(nameof(ProductId) , nameof(Color))]
    public class ProductColor
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null;
        public string Color { get; set; } = string.Empty;

    }
}
