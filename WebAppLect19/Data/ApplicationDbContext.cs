using Microsoft.EntityFrameworkCore;


namespace WebAppLect19.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSubImage> ProductSubImages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog = db2 ; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<ProductColor>()
        //    //    .HasKey(pc => new { pc.ProductId, pc.Color });

        //    //new ProductColorEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductColor>());


        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductColorEntityTypeConfiguration).Assembly);

        //    base.OnModelCreating(modelBuilder);


        //}
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)


    }
}
