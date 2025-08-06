using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_team.Migrations
{
    /// <inheritdoc />
    public partial class RenamePhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Contact");

            migrationBuilder.AddColumn<string>(
                name: "AltPhoneNumber",
                table: "Contact",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AltPhoneNumber",
                table: "Contact");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Contact",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
