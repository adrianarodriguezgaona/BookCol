using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3_Adriana_Kenny.web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    Community = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roomtypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roomtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Stars = table.Column<int>(maxLength: 1, nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: false),
                    NmbrOfRooms = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelId = table.Column<long>(nullable: false),
                    RoomtypeId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 350, nullable: false),
                    PriceNight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_Roomtypes_RoomtypeId",
                        column: x => x.RoomtypeId,
                        principalTable: "Roomtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckInDate = table.Column<DateTime>(nullable: false),
                    CheckOutDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<long>(nullable: false),
                    RoomId = table.Column<long>(nullable: false),
                    NmbrOfPeople = table.Column<int>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1L, "Ga je naar Colombia, dan moet je zeker een bezoek brengen aan de hoofdstad van Colombia. De hoofdstad van Colombia ligt in het midden van het land en wordt Bogota of Bogotá genoemd. Het is waarschijnlijk het eerste wat je ziet in Colombia, en dat bevalt meteen goed. Het is een gigantische stad, maar heeft leuke, sfeervolle plekjes", "Bogota", "Bogota.jpg" },
                    { 2L, "Wanneer je een bezoek aan Colombia brengt mag een bezoek aan Cartagena zeker niet ontbreken. Het is een van de bekendste steden aan de Caribische kust, een sprookjesachtige stad met romantiek, legendes en prachtig bewaard gebleven, eeuwen-oude koloniale oud centrum. Door de doolhof van geplaveide straatjes, gekleurde balkons en enorme kerken staat Cartagena op de Unesco World Heritage lijst.", "Cartagena", "Cartagena.jpg" },
                    { 3L, "Gelegen in een smalle vallei met een schitterende skyline is Medellin een van de mooist gelegen steden in Colombia. Het aangename klimaat geeft de stad zijn bijnaam – De Stad van de Eeuwige Lente", "Medellin", "Medellin.jpg" },
                    { 4L, "Colombia beschikt over verschillende eilanden.Denk bijvoorbeeld aan eilandgroepen als de Rosario - eilanden en de San Bernardo - eilanden.Ook heeft Colombia verschillende eilanden die niet direct voor de Colombiaanse kust liggen, maar wel een onderdeel van het land zijn.Een goed voorbeeld hiervan is San Andres wat in de Caribische Zee ligt", "San Andres", "SanAndres.jpg" },
                    { 5L, "Colombia beschikt over verschillende eilanden.Denk bijvoorbeeld aan eilandgroepen als de Rosario - eilanden en de San Bernardo - eilanden.Ook heeft Colombia verschillende eilanden die niet direct voor de Colombiaanse kust liggen, maar wel een onderdeel van het land zijn.Een goed voorbeeld hiervan is San Andres wat in de Caribische Zee ligt", "Santa Marta", "SantaMarta.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CityId", "Description", "Name", "NmbrOfRooms", "Photo", "Stars" },
                values: new object[,]
                {
                    { 1L, "Transversal 6 No 27 - 85", 1L, "Dit hotel ligt in Centro International, binnen 2 km afstand van Nationaal Museum en Goudmuseum. Ook Monserrate en Amerikaanse ambassade liggen binnen 5 km afstand.", "Ibis Bogota Museo ", 5, "IbisBogota.jpg", 4 },
                    { 2L, "Calle 95 Numero 13-35, Chapinero,", 1L, "Selina Parque 93 Bogota ligt in Bogotá en beschikt over een terras en een gemeenschappelijke lounge. Dit 3-sterrenhotel biedt een 24-uursreceptie, een gedeelde keuken en gratis WiFi. De accommodatie is rookvrij en ligt op 2,5 km van T Zone..", "Selina Parque 93", 5, "SelinaParque.jpg", 3 },
                    { 3L, "Cra 71 No 69-04, Engativa", 1L, "Deportel Bogotá ligt op 100 m van het La Europa Park en op 3 km van hetSimón Bolívar Park. Het beschikt over een gemeenschappelijke lounge en gratis WiFi in alle ruimtes.", "Deportel Bogotá", 5, "Deportel.jpg", 4 },
                    { 4L, "Avenida Carrera 7 # 69a-22, Chapinero", 1L, "Ga voor een sterrenbehandeling en geniet van service van wereldklasse in Four Seasons Hotel Casa Medina Bogotavan T Zone..", "Four Seasons Hotel Casa Medina", 5, "FourSeasonsCasaMedina", 3 },
                    { 5L, "Avenida Carrera 7 # 69a-22, Chapinero", 1L, " Een van onze bestsellers in Bogota!Expo Suites Parque Central Bavaria ligt in de financiële wijk van Bogotá.Het biedt een trendy,paars interieur met witte orchideeën en kamers met gratis WiFi.", "Expo Suites Parque Bavaria", 5, "ExpoSuitesParque", 3 },
                    { 6L, "Calle 34 # 11-15. Plazoleta Telecom, La Matuna", 2L, "Hotel Stil biedt ruime accommodatie met gratis WiFi en een pendeldienst van/naar de luchthaven. Het ligt in het historische centrum van Cartagena, dicht bij India Catalina in het traditionele stadsdeel La Matuta.", "Hotel Stil Cartagena", 5, "StilCartagena.jpg", 3 },
                    { 7L, "Bocagrande, Avenida 1A # Calle 9A Esquina, Bocagrande", 2L, "Costa del Sol ligt aan het strand van Bocagrande. De accommodatie biedt gratis WiFi en een zwembad op het dak met panoramisch uitzicht op de baai en de ommuurde stad Cartagena.", "Hotel Costa del Sol", 5, "CostaDelSol.jpg", 3 },
                    { 8L, "Calle 5 # 3 14 Bocagrande, Bocagrande,", 2L, "Hotel Zi One in Cartagena de Indias beschikt over een buitenbad en kamers met gratis WiFi en uitzicht op zee. De 4-sterrenaccommodatie ligt op 2,8 km van het Paleis van de Inquisitie, het Goudmuseum van Cartagena en het Bolivar-park.", "Hotel Zi One Luxury", 5, "ZiOneLuxury.jpg", 4 },
                    { 9L, "Bocagrande, Carrera. 1a # 2-87, Bocagrande", 2L, "Dit luxueuze hotel aan het Caribische strand heeft een buitenzwembad, stijlvolle koloniale architectuur en spafaciliteiten. U kunt massages en duiktrips reserveren. WiFi is gratis beschikbaar.", "Hotel Caribe By Faranda", 5, "CaribeByFaranda.jpg", 5 },
                    { 10L, "Centro historico, Calle del Sargento No. 6 - 87, Centro", 2L, "Dit moderne hotel ligt in het hart van de ommuurde stad Cartagena. Het bevindt zich in een gerenoveerd gebouw uit de 16e eeuw en beschikt over een dakterras met een zwembad en een gedeelde woonkamer. Het beschikt ook over een eigen gastronomisch restaurant en gratis WiFi.", "Bastión Luxury Hotel", 5, "BastionLuxury.jpg", 5 },
                    { 21L, "Calle 16 # 5-17, Centro Histórico", 5L, "Hotel Catedral Plaza ligt in Santa Marta in de regio Magdalena, op 5 km van het strand van El Rodadero. Het beschikt over een buitenbad en een zonneterras. Gasten kunnen genieten van de bar bij de accommodatie, en er wordt dagelijks een Amerikaans ontbijt aangeboden.", "Hotel Catedral Plaza", 5, "CatedralPlaza.jpg", 4 },
                    { 22L, "Km 17 vía a Cienaga", 5L, "Het hotel ligt op slechts 100 meter van het strand van Pozos Colorados en beschikt over een zwembad, 2 tennisbanen en een discobar. U kunt dineren in een restaurant in de vorm van een piratenschip.", "Decameron Galeon", 5, "DecameronGaleon.jpg", 3 },
                    { 23L, "Km 14 via a Cienaga. Bello Horizonte", 5L, "Het Irotama Resort ligt op 100 meter van het strand en biedt op het terrein zelf watersportactiviteiten, 3 buitenzwembaden en een spa- en fitnesscentrum. Er is WiFi beschikbaar. Er worden ook activiteiten voor kinderen georganiseerd. Er is bovendien gratis vervoer vanaf de luchthaven mogelijk.", "Irotama Resort", 5, "IrotamaResort.jpg", 5 },
                    { 24L, "Calle 11a No 6-136, El Rodadero, Cerro la Llorona", 5L, "Bunsizanisi Hotel ligt in de wijk El Rodadero van Santa Marta en beschikt over kamers met gratis WiFi. Tot de verschillende faciliteiten van deze accommodatie behoren een buitenzwembad, een tuin en een terras. De accommodatie ligt op 700 m van het strand El Rodadero.", "Bunsizanisi Hotel", 5, "Bunsizanisi.jpg", 3 },
                    { 25L, "Carrera 1C No. 24-04", 5L, "Hilton Garden Inn Santa Marta bevindt zich in Santa Marta, en biedt een buitenzwembad, een fitnesscentrum, een tuin en gratis WiFi. De accommodatie ligt op 6 km van het strand van El Rodadero, op 200 meter van de jachthaven van Santa Marta en op 1 km van de kathedraal van Santa Marta. Het hotel beschikt over een gemeenschappelijke lounge.", "Hilton Garden Inn Santa Marta", 5, "HiltonGardenInn.jpg", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ClientId",
                table: "Booking",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomtypeId",
                table: "Rooms",
                column: "RoomtypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Roomtypes");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
