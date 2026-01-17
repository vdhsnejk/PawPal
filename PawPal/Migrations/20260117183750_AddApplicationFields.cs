using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewedByAdminId",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminRemarks",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "AdminRemarks",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AdoptionApplication");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "AdoptionApplication");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewedByAdminId",
                table: "AdoptionApplication",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4c8d9c1-2d12-4b7b-9e8a-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8fdfcf-adc7-40ac-9c9d-d242a60ed5c5", "AQAAAAIAAYagAAAAEN2vcRkbrr4ud1lGEKqZu0Ur1LIzu/TceXtqt+XLn3vX4jR9RQnMFWQwMumz3RxmWA==", "02b76381-c429-4f2c-9512-623271025348" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1479), new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1486), new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1633), new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1638), new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1231), new DateTime(2026, 1, 18, 1, 33, 45, 30, DateTimeKind.Local).AddTicks(1232) });
        }
    }
}
