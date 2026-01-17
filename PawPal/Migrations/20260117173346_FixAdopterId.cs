using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawPal.Migrations
{
    /// <inheritdoc />
    public partial class FixAdopterId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdopterId",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AdopterId",
                table: "AdoptionApplication",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4c8d9c1-2d12-4b7b-9e8a-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27d58939-3208-4142-96da-4256454d1fc5", "AQAAAAIAAYagAAAAEK45vY1aL2ohfI/ujiFLThkh9faBA7btwJ57EZK3AqUissv2nwyIqicmJRmyKDXo4Q==", "65e1a27e-7f39-48c7-815f-58c26b428546" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4603), new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4609), new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4699), new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4703), new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4356), new DateTime(2026, 1, 16, 21, 5, 49, 163, DateTimeKind.Local).AddTicks(4358) });
        }
    }
}
