//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using PawPal.Data;

//namespace PawPal.Configurations.Entities;

//public class UserSeed : IEntityTypeConfiguration<PawPalUser>
//{
//    public void Configure(EntityTypeBuilder<PawPalUser> builder)
//    {
//        var hasher = new PasswordHasher<PawPalUser>();

//        builder.HasData(
//            new PawPalUser
//            {
//                Id = "a4c8d9c1-2d12-4b7b-9e8a-333333333333",
//                Email = "admin@localhost.com",
//                NormalizedEmail = "ADMIN@LOCALHOST.COM",
//                UserName = "admin@localhost.com",
//                NormalizedUserName = "ADMIN@LOCALHOST.COM",
//                FirstName = "Admin",
//                LastName = "User",
//                EmailConfirmed = true,
//                PasswordHash = hasher.HashPassword(null, "P@ssword1")
//            }
//        );
//    }
//}
