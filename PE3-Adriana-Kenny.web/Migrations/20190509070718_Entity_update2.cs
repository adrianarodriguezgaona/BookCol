using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class Entity_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Booking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RoomId",
                table: "Booking",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
