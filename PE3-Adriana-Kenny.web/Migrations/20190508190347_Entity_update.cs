using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class Entity_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Booking_BookingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BookingId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RoomId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Booking");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BookingId",
                table: "Rooms",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Booking_BookingId",
                table: "Rooms",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Booking_BookingId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_BookingId",
                table: "Rooms");

            migrationBuilder.AddColumn<long>(
                name: "BookingId",
                table: "Booking",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookingId",
                table: "Booking",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Booking_BookingId",
                table: "Booking",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
