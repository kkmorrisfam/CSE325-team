using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_team.Migrations
{
    /// <inheritdoc />
    public partial class SyncModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Vehicle_VehicleID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Vehicle",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Booking",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_VehicleID",
                table: "Booking",
                newName: "IX_Booking_VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Vehicle",
                newName: "VehicleID");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Booking",
                newName: "VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_VehicleId",
                table: "Booking",
                newName: "IX_Booking_VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Vehicle_VehicleID",
                table: "Booking",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
