using Microsoft.EntityFrameworkCore;
using Study_project.work_with_ORM.models;

namespace Study_project.work_with_ORM
{
    public class contextDB : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=usersdb;Username=postgres;Password=funcode");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .HasOne(p => p.Category)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
