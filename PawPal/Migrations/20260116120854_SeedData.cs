using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PawPal.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Breed", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Gender", "MedicalInfo", "Name", "ShelterId", "Size", "Species", "Status", "Temperament", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 2, "Mixed", "System", new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(679), new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(680), "Playful and loves walks", "Male", "Vaccinated", "Milo", 1, "Medium", "Dog", "Available", "Friendly", "System" },
                    { 2, 3, "Domestic Shorthair", "System", new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(687), new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(688), "Quiet and affectionate", "Female", "Sterilised", "Luna", 1, "Small", "Cat", "Available", "Calm", "System" }
                });

            migrationBuilder.InsertData(
                table: "PetImage",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ImageUrl", "IsPrimary", "PetId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(776), new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(776), "/images/pets/milo-1.jpg", true, 1, "System" },
                    { 2, "System", new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(780), new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(781), "/images/pets/luna-1.jpg", true, 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "Shelter",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Email", "PhoneNumber", "ShelterName", "UpdatedBy" },
                values: new object[] { 1, "Tampines, Singapore", "System", new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(234), new DateTime(2026, 1, 16, 20, 8, 54, 166, DateTimeKind.Local).AddTicks(234), "hello@pawpal.sg", "6123 4567", "PawPal Rescue Centre", "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
