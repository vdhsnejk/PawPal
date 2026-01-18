using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawPal.Domain;

namespace PawPal.Data
{
    public class PawPalContext : IdentityDbContext<PawPalUser>
    {
        public PawPalContext(DbContextOptions<PawPalContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pet { get; set; } = default!;
        public DbSet<Shelter> Shelter { get; set; } = default!;
        public DbSet<Appointment> Appointment { get; set; } = default!;
        public DbSet<AdoptionApplication> AdoptionApplication { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Pet>()
                .HasOne(p => p.Shelter)
                .WithMany(s => s.Pets)
                .HasForeignKey(p => p.ShelterId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Appointment>()
                .HasOne(a => a.Pet)
                .WithMany()
                .HasForeignKey(a => a.PetId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}