using Microsoft.EntityFrameworkCore;

namespace demo.Models.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

    public DbSet<AppartmentsTable> Appartments { get; set; }
    public DbSet<MetersTable> Meters { get; set; }
    public DbSet<ReadingsTable> Readings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppartmentsTable>()
            .HasOne(a => a.Meter)
            .WithOne(m => m.Appartment)
            .HasForeignKey<AppartmentsTable>(a => a.MeterId);
               
        modelBuilder.Entity<ReadingsTable>()
            .HasOne(r => r.Meter)
            .WithMany(m => m.Readings)
            .HasForeignKey(m => m.MeterId);        
    }      
}
