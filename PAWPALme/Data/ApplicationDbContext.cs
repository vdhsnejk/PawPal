using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PAWPALme.Models;

namespace PAWPALme.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Pet> Pet { get; set; } = default!;
        public DbSet<Shelter> Shelter { get; set; } = default!;
        public DbSet<Appointment> Appointment { get; set; } = default!;
        public DbSet<AdoptionApplication> AdoptionApplication { get; set; } = default!; // Added Stub

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Enforce Unique Shelter Owner
            builder.Entity<Shelter>()
                .HasIndex(s => s.OwnerUserId)
                .IsUnique()
                .HasFilter("[OwnerUserId] IS NOT NULL");

            // Prevent deleting a Shelter if it has Pets
            builder.Entity<Pet>()
                .HasOne(p => p.Shelter)
                .WithMany()
                .HasForeignKey(p => p.ShelterId)
                .OnDelete(DeleteBehavior.Restrict);

            // Appointment -> Application Relationship
            builder.Entity<Appointment>()
                .HasOne(a => a.AdoptionApplication)
                .WithMany()
                .HasForeignKey(a => a.AdoptionApplicationId)
                .OnDelete(DeleteBehavior.Cascade); // If application deleted, appointment deleted
        }
    }
}



