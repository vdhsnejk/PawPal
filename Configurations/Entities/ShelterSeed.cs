using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PawPal.Domain;

namespace PawPal.Configurations.Entities;

public class ShelterSeed : IEntityTypeConfiguration<Shelter>
{
    public void Configure(EntityTypeBuilder<Shelter> builder)
    {
        builder.HasData(
            new Shelter
            {
                Id = 1,
                ShelterName = "PawPal Rescue Centre",
                Address = "Tampines, Singapore",
                PhoneNumber = "6123 4567",
                Email = "hello@pawpal.sg",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }
        );
    }
}
