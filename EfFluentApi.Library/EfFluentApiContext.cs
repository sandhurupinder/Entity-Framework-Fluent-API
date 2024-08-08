using Microsoft.EntityFrameworkCore;

namespace EfFluentApi.Library
{
    public class EfFluentApiContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public EfFluentApiContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // -------------------------------------------
            // ----------       Set  Keys       ----------
            // -------------------------------------------
            modelBuilder.Entity<Category>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            // -------------------------------------------
            // ---------- Set column properties ----------
            // -------------------------------------------

            // ---------- Products ----------

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasColumnName("Desc");

            modelBuilder.Entity<Product>()       // Use for one to many and one to one relationships
                .Property(p => p.CategoryId)
                .IsRequired();
            
            // ---------- Categories ----------

            modelBuilder.Entity<Category>()
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            // -------------------------------------------
            // ----------     Relationships     ----------
            // -------------------------------------------
            
            // ---------- One category, many products ----------

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products);

            // ---------- One category, one product ----------

            // modelBuilder.Entity<Product>()
            //     .HasOne(p => p.Category)
            //     .WithOne(c => c.Product)
            //     .HasForeignKey<Category>(c => c.ProductId);

            // ---------- Many categories, many products ----------

            // modelBuilder.Entity<Product>()
            //     .HasMany(p => p.Categories)
            //     .WithMany(c => c.Products);
        }

    }
}
