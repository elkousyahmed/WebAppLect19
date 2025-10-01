using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebAppLect19.Data.EntityConfiguration
{
    public class ProductColorEntityTypeConfiguration : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.HasKey(pc => new { pc.ProductId, pc.Color });



        }
    }
}
