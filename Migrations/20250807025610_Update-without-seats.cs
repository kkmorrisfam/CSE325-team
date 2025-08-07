using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_team.Migrations
{
    /// <inheritdoc />
    public partial class Updatewithoutseats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Vehicles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Vehicles",
                type: "INTEGER",
                nullable: true);
        }
    }
}
