using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebAppLect19.Data.EntityConfiguration
{
    public class ProductImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductSubImage>
    {
        public void Configure(EntityTypeBuilder<ProductSubImage> b) // b= builder
        {
            b.HasKey(pc => new { pc.ProductId, pc.Img });

        }
    }
}
