using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawPal.Configurations.Entities;
using PawPal.Data;

namespace PawPal.Data
{
    public class PawPalContext(DbContextOptions<PawPalContext> options) : IdentityDbContext<PawPalUser>(options)
    {
        public DbSet<PawPal.Domain.Shelter> Shelter { get; set; } = default!;
        public DbSet<PawPal.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<PawPal.Domain.PetImage> PetImage { get; set; } = default!;
        public DbSet<PawPal.Domain.AdoptionApplication> AdoptionApplication { get; set; } = default!;
        public DbSet<PawPal.Domain.Appointment> Appointment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ShelterSeed());
            modelBuilder.ApplyConfiguration(new PetSeed());
            modelBuilder.ApplyConfiguration(new PetImageSeed());
        }
    }
}
