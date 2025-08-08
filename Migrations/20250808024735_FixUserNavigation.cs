using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_team.Migrations
{
    /// <inheritdoc />
    public partial class FixUserNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Booking",
                newName: "PickupDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Booking",
                newName: "DropOffDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PickupDate",
                table: "Booking",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DropOffDate",
                table: "Booking",
                newName: "EndDate");
        }
    }
}
