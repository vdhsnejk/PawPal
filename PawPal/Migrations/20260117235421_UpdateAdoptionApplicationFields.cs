using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdoptionApplicationFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "AdoptionApplication",
                newName: "ReasonForAdoption");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "AdoptionApplication",
                newName: "PrimaryCaregiver");

            migrationBuilder.AddColumn<bool>(
                name: "AnyoneAllergic",
                table: "AdoptionApplication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AvgHoursAlone",
                table: "AdoptionApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CurrentPetsDetails",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CurrentlyOwnPets",
                table: "AdoptionApplication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasLandlordOrFamilyApproval",
                table: "AdoptionApplication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HousingType",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetExperienceDetails",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PreparedForVetCare",
                table: "AdoptionApplication",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4c8d9c1-2d12-4b7b-9e8a-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c58e4eb-d4d1-4af9-b8ae-c6baf33bba26", "AQAAAAIAAYagAAAAEH/nrZpcRVfin85JXQWEYCubQWvZl95DLOjtV3NcEfOmcdiUDO28yHTrmlDLUQmwTQ==", "17eddc74-b9a2-4acd-ac2d-ef68105feb0b" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(993), new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(999), new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(1087), new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(1091), new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(770), new DateTime(2026, 1, 18, 7, 54, 20, 345, DateTimeKind.Local).AddTicks(771) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnyoneAllergic",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "AvgHoursAlone",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "CurrentPetsDetails",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "CurrentlyOwnPets",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "HasLandlordOrFamilyApproval",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "HousingType",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "PetExperienceDetails",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "PreparedForVetCare",
                table: "AdoptionApplication");

            migrationBuilder.RenameColumn(
                name: "ReasonForAdoption",
                table: "AdoptionApplication",
                newName: "Reason");

            migrationBuilder.RenameColumn(
                name: "PrimaryCaregiver",
                table: "AdoptionApplication",
                newName: "Experience");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4c8d9c1-2d12-4b7b-9e8a-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7ae49a-4298-414b-8c42-d773e73a0a76", "AQAAAAIAAYagAAAAEPzZJFpiW1t5LJNRpEQ99gURihtTRjbRTHG0b8P1WzOh1nCg6jgiT7n8Vj7jGRL0wA==", "3d24bf0d-a6bc-42b9-a657-b1e2c2035f2b" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8401), new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8410), new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8533), new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8538), new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8088), new DateTime(2026, 1, 18, 2, 37, 48, 724, DateTimeKind.Local).AddTicks(8089) });
        }
    }
}
