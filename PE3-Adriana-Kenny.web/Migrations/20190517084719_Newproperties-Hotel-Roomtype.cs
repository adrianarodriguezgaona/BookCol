using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class NewpropertiesHotelRoomtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxPersoons",
                table: "Roomtypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Facilities",
                table: "Hotels",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Photo" },
                values: new object[] { "Santa Marta is een belangrijke havenstad in Colombia, maar ook reizigers mogen de stad zeker niet overslaan. Santa Marta is namelijk de perfecte uitvalsbasis om de diversiteit van de Caribische kust te ontdekken. Om te dwalen in de groene jungle en te relaxen aan de paradijselijke stranden. De stad ligt namelijk niet alleen aan de noordelijke kust, maar ook aan de voet van het gebergte Sierra Nevada de Santa Marta.", null });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,restaurant,bar,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,airconditioning,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers,bar,restaurant,wasservice,airconditioning,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle,bar,restaurant,gratis parkeergelegenheid,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle,bar,restaurant,airconditioning,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Facilities",
                value: "Gratis wifi,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Facilities",
                value: "Gratis wifi,luchthavenshuttle,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,gratis parkeergelegenheid,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,airconditioning,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,gratis parkeergelegenheid,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenhei,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,luchthavenshuttle,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Facilities",
                value: "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,zwembad,goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Roomtypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MaxPersoons",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Roomtypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MaxPersoons",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Roomtypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MaxPersoons",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Roomtypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MaxPersoons",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Roomtypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MaxPersoons",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxPersoons",
                table: "Roomtypes");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Photo" },
                values: new object[] { "Colombia beschikt over verschillende eilanden.Denk bijvoorbeeld aan eilandgroepen als de Rosario - eilanden en de San Bernardo - eilanden.Ook heeft Colombia verschillende eilanden die niet direct voor de Colombiaanse kust liggen, maar wel een onderdeel van het land zijn.Een goed voorbeeld hiervan is San Andres wat in de Caribische Zee ligt", "SantaMarta.jpg" });
        }
    }
}
