using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAWPALme.Migrations
{
    /// <inheritdoc />
    public partial class AddShelterRemarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShelterRemarks",
                table: "Appointment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShelterRemarks",
                table: "Appointment");
        }
    }
}
