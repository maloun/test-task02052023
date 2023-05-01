using demo.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace demo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<AppartmentModel> Appartments { get; set; }
        public DbSet<MeterModel> Meters { get; set; }
        public DbSet<ReadingsModel> Readings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppartmentModel>()
                .HasOne(a => a.Meter)
                .WithOne(b => b.Appartment)
                .HasForeignKey<AppartmentModel>(b => b.MeterId);
        }      
    }
}
