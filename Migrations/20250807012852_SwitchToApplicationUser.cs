using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSE325_team.Migrations
{
    /// <inheritdoc />
    public partial class SwitchToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_AspNetUsers_UserId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Booking_BookingId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserId",
                table: "Payments",
                newName: "IX_Payments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_BookingId",
                table: "Payments",
                newName: "IX_Payments_BookingId");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Bookings",
                newName: "PickupDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Bookings",
                newName: "DropOffDate");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_VehicleId",
                table: "Bookings",
                newName: "IX_Bookings_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_UserId",
                table: "Bookings",
                newName: "IX_Bookings_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserId",
                table: "Payment",
                newName: "IX_Payment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_BookingId",
                table: "Payment",
                newName: "IX_Payment_BookingId");

            migrationBuilder.RenameColumn(
                name: "PickupDate",
                table: "Booking",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DropOffDate",
                table: "Booking",
                newName: "EndDate");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_VehicleId",
                table: "Booking",
                newName: "IX_Booking_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserId",
                table: "Booking",
                newName: "IX_Booking_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_AspNetUsers_UserId",
                table: "Payment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Booking_BookingId",
                table: "Payment",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "BookingId");
        }
    }
}
