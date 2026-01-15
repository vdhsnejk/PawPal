using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAWPALme.Migrations
{
    /// <inheritdoc />
    public partial class RefactorArchitecture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AspNetUsers_UserId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Pet_PetId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Shelter_ShelterId1",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelter_AspNetUsers_ApplicationUserId",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_Shelter_ApplicationUserId",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_Pet_ShelterId1",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_UserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ShelterId1",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "AdopterEmail",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AdopterName",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Shelter",
                newName: "OwnerUserId");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "Appointment",
                newName: "AdoptionApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_PetId",
                table: "Appointment",
                newName: "IX_Appointment_AdoptionApplicationId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shelter",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shelter",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Shelter",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Pet",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Pet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Appointment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AppointmentTime",
                table: "Appointment",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "ManagedByUserId",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Appointment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdoptionApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdoptionApplication_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shelter_OwnerUserId",
                table: "Shelter",
                column: "OwnerUserId",
                unique: true,
                filter: "[OwnerUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_PetId",
                table: "AdoptionApplication",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_UserId",
                table: "AdoptionApplication",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AdoptionApplication_AdoptionApplicationId",
                table: "Appointment",
                column: "AdoptionApplicationId",
                principalTable: "AdoptionApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_AdoptionApplication_AdoptionApplicationId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "AdoptionApplication");

            migrationBuilder.DropIndex(
                name: "IX_Shelter_OwnerUserId",
                table: "Shelter");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ManagedByUserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "Shelter",
                newName: "ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "AdoptionApplicationId",
                table: "Appointment",
                newName: "PetId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_AdoptionApplicationId",
                table: "Appointment",
                newName: "IX_Appointment_PetId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shelter",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shelter",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Shelter",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Pet",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ShelterId1",
                table: "Pet",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AdopterEmail",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdopterName",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Appointment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shelter_ApplicationUserId",
                table: "Shelter",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_ShelterId1",
                table: "Pet",
                column: "ShelterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_UserId",
                table: "Appointment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_AspNetUsers_UserId",
                table: "Appointment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Pet_PetId",
                table: "Appointment",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Shelter_ShelterId1",
                table: "Pet",
                column: "ShelterId1",
                principalTable: "Shelter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelter_AspNetUsers_ApplicationUserId",
                table: "Shelter",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
