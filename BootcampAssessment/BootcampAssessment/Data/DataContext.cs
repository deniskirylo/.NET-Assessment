using BootcampAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace BootcampAssessment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }    
        public DbSet<Claim> Claim { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OwnerCategory>()
                .HasKey(pc => new { pc.OwnerId, pc.VehicleId });
            modelBuilder.Entity<OwnerCategory>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.OwnerCategories)
                .HasForeignKey(c => c.OwnerId);
            modelBuilder.Entity<OwnerCategory>()
                .HasOne(p => p.Vehicle)
                .WithMany(pc => pc.OwnerCategories)
                .HasForeignKey(c => c.VehicleId);
        }
    }
}
