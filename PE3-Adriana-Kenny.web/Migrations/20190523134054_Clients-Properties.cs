using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class ClientsProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Clients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RepeatPassword",
                table: "Clients",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Community", "Country", "Email", "IsAdmin", "Name", "Password", "RepeatPassword", "Surname", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "Molenaarsstraat 35", "Brugge", "België", "adri_mrg@yahoo.com", true, "Rodriguez", "842164ceb65c19e602a9736657593f60", null, "Adriana", 8200 },
                    { 2L, "Congostraat 17A", "Aalter", "België", "kenny.zasada@gmail.com", true, "Zasada", "842164ceb65c19e602a9736657593f60", null, "Kenny", 9880 }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, 24-uursreceptie, bar, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, restaurant, bar, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, 24-uursreceptie, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, 24-uursreceptie, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, 24-uursreceptie, bar, restaurant, airconditioning, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, 24-uursreceptie, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle, bar, restaurant, gratis parkeergelegenheid, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle, bar, restaurant, airconditioning, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Facilities",
                value: "Gratis wifi, bar, restaurant, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Facilities",
                value: "Gratis wifi, luchthavenshuttle, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, gratis parkeergelegenheid, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, airconditioning, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, gratis parkeergelegenheid, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenhei, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, wasservice, luchthavenshuttle, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, wasservice, goed ontbijt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Facilities",
                value: "Gratis wifi, rookvrije kamers, bar, restaurant, gratis parkeergelegenheid, zwembad, goed ontbijt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RepeatPassword",
                table: "Clients");

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
        }
    }
}
