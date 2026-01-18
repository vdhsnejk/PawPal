using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PawPal.Domain;

namespace PawPal.Configurations.Entities;

public class PetSeed : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.HasData(
            new Pet
            {
                Id = 1,
                ShelterId = 1,
                Name = "Milo",
                Species = "Dog",
                Breed = "Mixed",
                Age = 2,
                Size = "Medium",
                Gender = "Male",
                Temperament = "Friendly",
                MedicalInfo = "Vaccinated",
                Description = "Playful and loves walks",
                Status = "Available",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new Pet
            {
                Id = 2,
                ShelterId = 1,
                Name = "Luna",
                Species = "Cat",
                Breed = "Domestic Shorthair",
                Age = 3,
                Size = "Small",
                Gender = "Female",
                Temperament = "Calm",
                MedicalInfo = "Sterilised",
                Description = "Quiet and affectionate",
                Status = "Available",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
}
