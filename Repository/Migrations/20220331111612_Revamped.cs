using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Revamped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JourneyId",
                table: "Receipts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "Receipts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "JourneyId1",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Journeys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "Journeys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_TripReviews_BookingId",
                table: "TripReviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_TripReviews_CustomerId",
                table: "TripReviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_BookingId",
                table: "Receipts",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_JourneyId1",
                table: "Receipts",
                column: "JourneyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_BookingId",
                table: "Journeys",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_DriverId",
                table: "Journeys",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverReviews_CarId",
                table: "DriverReviews",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverReviews_CustomerId",
                table: "DriverReviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverReviews_DriverId",
                table: "DriverReviews",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CarId",
                table: "Bookings",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DriverId",
                table: "Bookings",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Drivers_DriverId",
                table: "Bookings",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverReviews_Cars_CarId",
                table: "DriverReviews",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverReviews_Customers_CustomerId",
                table: "DriverReviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverReviews_Drivers_DriverId",
                table: "DriverReviews",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Journeys_Bookings_BookingId",
                table: "Journeys",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Journeys_Drivers_DriverId",
                table: "Journeys",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Bookings_BookingId",
                table: "Receipts",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Journeys_JourneyId1",
                table: "Receipts",
                column: "JourneyId1",
                principalTable: "Journeys",
                principalColumn: "JourneyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripReviews_Bookings_BookingId",
                table: "TripReviews",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TripReviews_Customers_CustomerId",
                table: "TripReviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Drivers_DriverId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverReviews_Cars_CarId",
                table: "DriverReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverReviews_Customers_CustomerId",
                table: "DriverReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverReviews_Drivers_DriverId",
                table: "DriverReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Journeys_Bookings_BookingId",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "FK_Journeys_Drivers_DriverId",
                table: "Journeys");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Bookings_BookingId",
                table: "Receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Journeys_JourneyId1",
                table: "Receipts");

            migrationBuilder.DropForeignKey(
                name: "FK_TripReviews_Bookings_BookingId",
                table: "TripReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_TripReviews_Customers_CustomerId",
                table: "TripReviews");

            migrationBuilder.DropIndex(
                name: "IX_TripReviews_BookingId",
                table: "TripReviews");

            migrationBuilder.DropIndex(
                name: "IX_TripReviews_CustomerId",
                table: "TripReviews");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_BookingId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_JourneyId1",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_BookingId",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_DriverId",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_DriverReviews_CarId",
                table: "DriverReviews");

            migrationBuilder.DropIndex(
                name: "IX_DriverReviews_CustomerId",
                table: "DriverReviews");

            migrationBuilder.DropIndex(
                name: "IX_DriverReviews_DriverId",
                table: "DriverReviews");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CarId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DriverId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "JourneyId1",
                table: "Receipts");

            migrationBuilder.AlterColumn<int>(
                name: "JourneyId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Journeys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "Journeys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
