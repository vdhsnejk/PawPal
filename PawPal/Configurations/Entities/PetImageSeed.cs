using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PawPal.Domain;

namespace PawPal.Configurations.Entities;

public class PetImageSeed : IEntityTypeConfiguration<PetImage>
{
    public void Configure(EntityTypeBuilder<PetImage> builder)
    {
        builder.HasData(
            new PetImage
            {
                Id = 1,
                PetId = 1,
                ImageUrl = "/images/pets/milo-1.jpg",
                IsPrimary = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            },
            new PetImage
            {
                Id = 2,
                PetId = 2,
                ImageUrl = "/images/pets/luna-1.jpg",
                IsPrimary = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
}
