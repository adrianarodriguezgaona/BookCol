using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class db_done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Clients_ClientBookingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId1",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId1",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ClientBookingId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ClientBookingId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Roomtypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Rooms",
                newName: "RoomtypeId");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Hotels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Booking",
                newName: "ClientId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Roomtypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "HotelId",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BookingId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomtypeId",
                table: "Rooms",
                column: "RoomtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ClientId",
                table: "Booking",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Clients_ClientId",
                table: "Booking",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Roomtypes_RoomtypeId",
                table: "Rooms",
                column: "RoomtypeId",
                principalTable: "Roomtypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Clients_ClientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Roomtypes_RoomtypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomtypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ClientId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RoomId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roomtypes",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "RoomtypeId",
                table: "Rooms",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hotels",
                newName: "HotelId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Booking",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Roomtypes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddColumn<long>(
                name: "CityId1",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientBookingId",
                table: "Booking",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId1",
                table: "Hotels",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ClientBookingId",
                table: "Booking",
                column: "ClientBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Clients_ClientBookingId",
                table: "Booking",
                column: "ClientBookingId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId1",
                table: "Hotels",
                column: "CityId1",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
