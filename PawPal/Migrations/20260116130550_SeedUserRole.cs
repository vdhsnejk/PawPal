using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PawPal.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b5a1b57c-0f7f-4b19-b17f-111111111111", null, "Administrator", "ADMINISTRATOR" },
                    { "c6b1b57c-0f7f-4b19-b17f-222222222222", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a4c8d9c1-2d12-4b7b-9e8a-333333333333", 0, "27d58939-3208-4142-96da-4256454d1fc5", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEK45vY1aL2ohfI/ujiFLThkh9faBA7btwJ57EZK3AqUissv2nwyIqicmJRmyKDXo4Q==", null, false, "65e1a27e-7f39-48c7-815f-58c26b428546", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b5a1b57c-0f7f-4b19-b17f-111111111111", "a4c8d9c1-2d12-4b7b-9e8a-333333333333" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6b1b57c-0f7f-4b19-b17f-222222222222");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b5a1b57c-0f7f-4b19-b17f-111111111111", "a4c8d9c1-2d12-4b7b-9e8a-333333333333" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a1b57c-0f7f-4b19-b17f-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4c8d9c1-2d12-4b7b-9e8a-333333333333");

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9930), new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9937), new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 20, 41, 39, 599, DateTimeKind.Local).AddTicks(21), new DateTime(2026, 1, 16, 20, 41, 39, 599, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "PetImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 20, 41, 39, 599, DateTimeKind.Local).AddTicks(24), new DateTime(2026, 1, 16, 20, 41, 39, 599, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Shelter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9718), new DateTime(2026, 1, 16, 20, 41, 39, 598, DateTimeKind.Local).AddTicks(9719) });
        }
    }
}
