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
                    Surname = table.Column<string>(nullable: false),
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
                    Type = table.Column<string>(nullable: false),
                    MaxPersoons = table.Column<int>(nullable: false)
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
                    Description = table.Column<string>(nullable: false),
                    Facilities = table.Column<string>(nullable: true)
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
                    RoomTypeId = table.Column<long>(nullable: false),
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
                        name: "FK_Rooms_Roomtypes_RoomTypeId",
                        column: x => x.RoomTypeId,
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
                    { 5L, "Santa Marta is een belangrijke havenstad in Colombia, maar ook reizigers mogen de stad zeker niet overslaan. Santa Marta is namelijk de perfecte uitvalsbasis om de diversiteit van de Caribische kust te ontdekken. Om te dwalen in de groene jungle en te relaxen aan de paradijselijke stranden. De stad ligt namelijk niet alleen aan de noordelijke kust, maar ook aan de voet van het gebergte Sierra Nevada de Santa Marta.", "Santa Marta", "SantaMarta.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roomtypes",
                columns: new[] { "Id", "MaxPersoons", "Type" },
                values: new object[,]
                {
                    { 1L, 2, "Suite met Uitzicht op Zee" },
                    { 2L, 2, "Suite" },
                    { 3L, 2, "Tweepersoonskamer" },
                    { 4L, 3, "Driepersoonskamer" },
                    { 5L, 2, "Tweepersoonskamer met 2 aparte bedden" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CityId", "Description", "Facilities", "Name", "NmbrOfRooms", "Photo", "Stars" },
                values: new object[,]
                {
                    { 1L, "Transversal 6 No 27 - 85", 1L, "Dit hotel ligt in Centro International, binnen 2 km afstand van Nationaal Museum en Goudmuseum. Ook Monserrate en Amerikaanse ambassade liggen binnen 5 km afstand.", "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,goed ontbijt", "Ibis Bogota Museo ", 5, "IbisBogota.jpg", 4 },
                    { 23L, "Km 14 via a Cienaga. Bello Horizonte", 5L, "Het Irotama Resort ligt op 100 meter van het strand en biedt op het terrein zelf watersportactiviteiten, 3 buitenzwembaden en een spa- en fitnesscentrum. Er is WiFi beschikbaar. Er worden ook activiteiten voor kinderen georganiseerd. Er is bovendien gratis vervoer vanaf de luchthaven mogelijk.", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,luchthavenshuttle,goed ontbijt", "Irotama Resort", 5, "IrotamaResort.jpg", 5 },
                    { 22L, "Km 17 vía a Cienaga", 5L, "Het hotel ligt op slechts 100 meter van het strand van Pozos Colorados en beschikt over een zwembad, 2 tennisbanen en een discobar. U kunt dineren in een restaurant in de vorm van een piratenschip.", "Gratis wifi,rookvrije kamers,bar,wasservice,goed ontbijt", "Decameron Galeon", 5, "DecameronGaleon.jpg", 3 },
                    { 21L, "Calle 16 # 5-17, Centro Histórico", 5L, "Hotel Catedral Plaza ligt in Santa Marta in de regio Magdalena, op 5 km van het strand van El Rodadero. Het beschikt over een buitenbad en een zonneterras. Gasten kunnen genieten van de bar bij de accommodatie, en er wordt dagelijks een Amerikaans ontbijt aangeboden.", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenhei,goed ontbijt", "Hotel Catedral Plaza", 5, "CatedralPlaza.jpg", 4 },
                    { 20L, "Via san luis, 880001 San Andrés.", 4L, "Hostal Rohomar biedt gratis WiFi en uitzicht op zee in San Andrés. Het pension ligt op ongeveer 2,6 km van de baai van San Andres en op 3,5 km van North End. Lokale bezienswaardigheden zoals Spratt Bight en The Hill zijn bereikbaar binnen respectievelijk 3,7 km en 1,9 km.", "Gratis wifi,rookvrije kamers,bar,gratis parkeergelegenheid,wasservice,goed ontbijt", "Hostal Rohomar", 5, "HostalRohomar.jpg", 3 },
                    { 19L, "Via San Luis, Antes de Rocky Cay Bay,  San Andrés.", 4L, "San Luis Place By El Dorado ligt in San Andrés, in de omgeving van de eilanden San Andres en Providencia, op nog geen 3,5 km van San Andrés-baai, en beschikt over een zonneterras en een eigen strand.", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,airconditioning,goed ontbijt", "San Luis Place By El Dorado", 5, "ElDorado.jpg", 5 },
                    { 18L, "Vía a San Luis # 43-39, San Andrés.", 4L, "Hotel Cocoplum Beach ligt aan het Cocoplum - strand, een van de mooiste stranden van San Andrés. Het biedt een zwembad, een spa en een restaurant met uitzicht op zee. Er is gratis WiFi beschikbaar in de gemeenschappelijke ruimtes en het hotel serveert ontbijt.", "Gratis wifi,rookvrije kamers,bar,gratis parkeergelegenheid,goed ontbijt", "Hotel Cocoplum Beach", 5, "CocoplumBeach.jpg", 4 },
                    { 17L, "Calle 3 18 - 71 , San Andrés.", 4L, "Deze elegante villa in mediterrane stijl heeft een buitenzwembad.U kunt er verblijven in kamers met airconditioning en gratis WiFi. Er is ook gratis privéparkeergelegenheid beschikbaar.", "Gratis wifi,luchthavenshuttle,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt", "Le Castel Blanc Hotel Boutique", 5, "LeCastelBlanc.jpg", 5 },
                    { 16L, "Av. 20 de Julio Nº 3A - 122, San Andrés.", 4L, "San Andrés Hostel heeft kamers met airconditioning.Het ligt op slechts 5 minuten lopen van het strand en de zee van 7 kleuren.Er is een discobar bij de accommodatie en er zijn duiklessen beschikbaar. ", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt", "Viajero San Andres Hostel", 5, "ViajeroSanandresHostel.jpg ", 4 },
                    { 15L, "CR 69 46B 34, Laureles, Medellín.", 3L, "Mooie, schone kamers met een moderne badkamer. Op loopafstand van het metrostation en om de hoek van een gezellige uitgaansstraat in Medellin met leuke restaurants e.d.waar weinig toeristen komen en je dus meer tussen de locals zit. Top locatie!", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt", "HOTEL MED 70", 5, "Med70.jpg", 4 },
                    { 14L, "Carrera 32d # 9-17, El Poblado, Medellín.", 3L, "Selina Medellin ligt in Medellín en biedt een terras, een gemeenschappelijke lounge, een restaurant, een 24 - uursreceptie, een gemeenschappelijke keuken en gratis WiFi. Voor een drankje kunt u terecht bij de bar.", "Gratis wifi,rookvrije kamers,bar,restaurant,wasservice,goed ontbijt", "Selina Medellin", 5, "SelinaMedellin.jpg", 3 },
                    { 24L, "Calle 11a No 6-136, El Rodadero, Cerro la Llorona", 5L, "Bunsizanisi Hotel ligt in de wijk El Rodadero van Santa Marta en beschikt over kamers met gratis WiFi. Tot de verschillende faciliteiten van deze accommodatie behoren een buitenzwembad, een tuin en een terras. De accommodatie ligt op 700 m van het strand El Rodadero.", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,wasservice,goed ontbijt", "Bunsizanisi Hotel", 5, "Bunsizanisi.jpg", 3 },
                    { 13L, "3324 Carrera 65, Laureles, Medellín", 3L, "Hotel Medellin 33 ligt op 2,9 km van Pueblito Paisa, in Medellín.Het biedt een aantal voorzieningen, waaronder een buitenzwembad, een fitnesscentrum en een terras.Tot de faciliteiten van deze accommodatie behoren een restaurant, een 24 - uursreceptie, een gemeenschappelijke lounge en gratis WiFi. De accommodatie beschikt over een hot tub, entertainmentpersoneel en roomservice.", "Gratis wifi,rookvrije kamers,bar,restaurant,wasservice,goed ontbijt", "Hotel Medellin 33", 5, "Medellin33.jpg", 3 },
                    { 11L, "Carrera 42 A No. 1 - 15, El Poblado, Medellín", 3L, "San Fernando Plaza beschikt over een verwarmd buitenzwembad, een spa en een fitnesscentrum.Het biedt luxe accommodatie in El Poblado, de exclusieve financiële en commerciële wijk van Medellin.Het hotel heeft ook een restaurant en een bar.", "Gratis wifi, luchthavenshuttle,bar,restaurant,airconditioning,goed ontbijt", "Hotel San Fernando Plaza", 5, "SanFernandoPlaza.jpg", 5 },
                    { 10L, "Centro historico, Calle del Sargento No. 6 - 87, Centro", 2L, "Dit moderne hotel ligt in het hart van de ommuurde stad Cartagena. Het bevindt zich in een gerenoveerd gebouw uit de 16e eeuw en beschikt over een dakterras met een zwembad en een gedeelde woonkamer. Het beschikt ook over een eigen gastronomisch restaurant en gratis WiFi.", "Gratis wifi, luchthavenshuttle,bar,restaurant,gratis parkeergelegenheid,goed ontbijt", "Bastión Luxury Hotel", 5, "BastionLuxury.jpg", 5 },
                    { 9L, "Bocagrande, Carrera. 1a # 2-87, Bocagrande", 2L, "Dit luxueuze hotel aan het Caribische strand heeft een buitenzwembad, stijlvolle koloniale architectuur en spafaciliteiten. U kunt massages en duiktrips reserveren. WiFi is gratis beschikbaar.", "Gratis wifi, luchthavenshuttle,bar,restaurant,wasservice,goed ontbijt", "Hotel Caribe By Faranda", 5, "CaribeByFaranda.jpg", 5 },
                    { 8L, "Calle 5 # 3 14 Bocagrande, Bocagrande,", 2L, "Hotel Zi One in Cartagena de Indias beschikt over een buitenbad en kamers met gratis WiFi en uitzicht op zee. De 4-sterrenaccommodatie ligt op 2,8 km van het Paleis van de Inquisitie, het Goudmuseum van Cartagena en het Bolivar-park.", "Gratis wifi, rookvrije kamers,bar,restaurant,wasservice,airconditioning,goed ontbijt", "Hotel Zi One Luxury", 5, "ZiOneLuxury.jpg", 4 },
                    { 7L, "Bocagrande, Avenida 1A # Calle 9A Esquina, Bocagrande", 2L, "Costa del Sol ligt aan het strand van Bocagrande. De accommodatie biedt gratis WiFi en een zwembad op het dak met panoramisch uitzicht op de baai en de ommuurde stad Cartagena.", "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt", "Hotel Costa del Sol", 5, "CostaDelSol.jpg", 3 },
                    { 6L, "Calle 34 # 11-15. Plazoleta Telecom, La Matuna", 2L, "Hotel Stil biedt ruime accommodatie met gratis WiFi en een pendeldienst van/naar de luchthaven. Het ligt in het historische centrum van Cartagena, dicht bij India Catalina in het traditionele stadsdeel La Matuta.", "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,airconditioning,goed ontbijt", "Hotel Stil Cartagena", 5, "StilCartagena.jpg", 3 },
                    { 5L, "Avenida Carrera 7 # 69a-22, Chapinero", 1L, " Een van onze bestsellers in Bogota!Expo Suites Parque Central Bavaria ligt in de financiële wijk van Bogotá.Het biedt een trendy,paars interieur met witte orchideeën en kamers met gratis WiFi.", "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt", "Expo Suites Parque Bavaria", 5, "ExpoSuitesParque.jpg", 3 },
                    { 4L, "Avenida Carrera 7 # 69a-22, Chapinero", 1L, "Ga voor een sterrenbehandeling en geniet van service van wereldklasse in Four Seasons Hotel Casa Medina Bogotavan T Zone..", "Gratis wifi, luchthavenshuttle,bar,restaurant,wasservice,goed ontbijt", "Four Seasons Hotel Casa Medina", 5, "FourSeasonsCasaMedina.jpg", 3 },
                    { 3L, "Cra 71 No 69-04, Engativa", 1L, "Deportel Bogotá ligt op 100 m van het La Europa Park en op 3 km van hetSimón Bolívar Park. Het beschikt over een gemeenschappelijke lounge en gratis WiFi in alle ruimtes.", "Gratis wifi, rookvrije kamers,24-uursreceptie,bar,restaurant,wasservice,goed ontbijt", "Deportel Bogotá", 5, "Deportel.jpg", 4 },
                    { 2L, "Calle 95 Numero 13-35, Chapinero,", 1L, "Selina Parque 93 Bogota ligt in Bogotá en beschikt over een terras en een gemeenschappelijke lounge. Dit 3-sterrenhotel biedt een 24-uursreceptie, een gedeelde keuken en gratis WiFi. De accommodatie is rookvrij en ligt op 2,5 km van T Zone..", "Gratis wifi, rookvrije kamers,restaurant,bar,goed ontbijt", "Selina Parque 93", 5, "SelinaParque.jpg", 3 },
                    { 12L, "Carrera 45 # 49-35, La Candelaria, Medellín.", 3L, "Hotel Suite 45 ligt in Medellin, op slechts 1 km van het metrostation Parque Berrio en biedt kamers met gratis WiFi en kabel-tv. Bij de accommodatie is gratis parkeergelegenheid beschikbaar. Het centrale plein en het Botero-plein liggen op 1 km afstand.", "Gratis wifi,bar,restaurant,wasservice,goed ontbijt", "Hotel Suite 45", 5, "Suite45.jpg", 3 },
                    { 25L, "Carrera 1C No. 24-04", 5L, "Hilton Garden Inn Santa Marta bevindt zich in Santa Marta, en biedt een buitenzwembad, een fitnesscentrum, een tuin en gratis WiFi. De accommodatie ligt op 6 km van het strand van El Rodadero, op 200 meter van de jachthaven van Santa Marta en op 1 km van de kathedraal van Santa Marta. Het hotel beschikt over een gemeenschappelijke lounge.", "Gratis wifi,rookvrije kamers,bar,restaurant,gratis parkeergelegenheid,zwembad,goed ontbijt", "Hilton Garden Inn Santa Marta", 5, "HiltonGardenInn.jpg", 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "HotelId", "PriceNight", "RoomTypeId" },
                values: new object[,]
                {
                    { 1L, "Deze suite heeft een balkon een eigen ingang en een zithoek.", 1L, 80m, 2L },
                    { 91L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 19L, 120m, 1L },
                    { 90L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 18L, 95m, 4L },
                    { 89L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 18L, 95m, 4L },
                    { 88L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 18L, 75m, 5L },
                    { 87L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 18L, 120m, 2L },
                    { 86L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 18L, 150m, 1L },
                    { 85L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 17L, 90m, 4L },
                    { 84L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 17L, 90m, 4L },
                    { 83L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 17L, 75m, 5L },
                    { 82L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.", 17L, 70m, 3L },
                    { 81L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 17L, 140m, 1L },
                    { 80L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 16L, 70m, 4L },
                    { 79L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 16L, 70m, 4L },
                    { 78L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 16L, 50m, 5L },
                    { 77L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.", 16L, 45m, 3L },
                    { 76L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 16L, 45m, 3L },
                    { 75L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 15L, 100m, 4L },
                    { 74L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 15L, 100m, 4L },
                    { 73L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 15L, 90m, 5L },
                    { 72L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.", 15L, 90m, 3L },
                    { 71L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 15L, 55m, 3L },
                    { 70L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 14L, 100m, 4L },
                    { 69L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 14L, 100m, 4L },
                    { 68L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 14L, 90m, 5L },
                    { 67L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 14L, 90m, 5L },
                    { 66L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 14L, 85m, 3L },
                    { 65L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 13L, 75m, 4L },
                    { 92L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 19L, 100m, 2L },
                    { 93L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 19L, 85m, 5L },
                    { 94L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 19L, 95m, 4L },
                    { 95L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 19L, 95m, 4L },
                    { 123L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 25L, 90m, 5L },
                    { 122L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 25L, 140m, 2L },
                    { 121L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 25L, 160m, 1L },
                    { 120L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 24L, 100m, 4L },
                    { 119L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ", 24L, 80m, 3L },
                    { 118L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 24L, 80m, 5L },
                    { 117L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 24L, 80m, 3L },
                    { 116L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 24L, 130m, 1L },
                    { 115L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 23L, 110m, 4L },
                    { 114L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ", 23L, 90m, 3L },
                    { 113L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 23L, 100m, 5L },
                    { 112L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 23L, 90m, 3L },
                    { 111L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 23L, 160m, 1L },
                    { 64L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 13L, 75m, 4L },
                    { 110L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 22L, 105m, 4L },
                    { 108L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 22L, 90m, 5L },
                    { 107L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 22L, 150m, 2L },
                    { 106L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 22L, 170m, 1L },
                    { 105L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 21L, 100m, 4L },
                    { 104L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 21L, 100m, 4L },
                    { 103L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 21L, 80m, 5L },
                    { 102L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 21L, 130m, 2L },
                    { 101L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 21L, 150m, 1L },
                    { 100L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 20L, 110m, 4L },
                    { 99L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 20L, 110m, 4L },
                    { 98L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 20L, 90m, 5L },
                    { 97L, "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning", 20L, 150m, 2L },
                    { 96L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 20L, 180m, 1L },
                    { 109L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 22L, 105m, 4L },
                    { 124L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ", 25L, 90m, 3L },
                    { 63L, "Tweepersoonskamer met 2 eenpersoonsbedden ,betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 13L, 60m, 5L },
                    { 61L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 13L, 85m, 2L },
                    { 28L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning", 6L, 70m, 5L },
                    { 27L, "Deze suite heeft een balkon, een eigen ingang en een zithoek en  airconditioning ", 6L, 90m, 2L },
                    { 26L, "Deze suite heeft een balkon,een betegelde / marmeren vloer en airconditioning", 6L, 100m, 1L },
                    { 25L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 5L, 75m, 4L },
                    { 24L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 5L, 75m, 4L },
                    { 23L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer", 5L, 65m, 5L },
                    { 22L, "Deze suite heeft een balkon, een eigen ingang en een zithoek ", 5L, 95m, 2L },
                    { 21L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 5L, 95m, 2L },
                    { 20L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 4L, 65m, 4L },
                    { 19L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 4L, 65m, 4L },
                    { 18L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer", 4L, 55m, 5L },
                    { 17L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer ", 4L, 55m, 5L },
                    { 16L, "Deze suite heeft een balkon,een eigen ingang en een zithoek", 4L, 80m, 2L },
                    { 15L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 3L, 80m, 4L },
                    { 14L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer", 3L, 80m, 4L },
                    { 13L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer", 3L, 70m, 5L },
                    { 12L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer ", 3L, 70m, 5L },
                    { 11L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.", 3L, 60m, 3L },
                    { 10L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.", 2L, 60m, 4L },
                    { 9L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.", 2L, 60m, 4L },
                    { 8L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.", 2L, 40m, 3L },
                    { 7L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.", 2L, 40m, 3L },
                    { 6L, "Deze suite heeft een balkon, een eigen ingang en een zithoek", 2L, 90m, 2L },
                    { 5L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.", 1L, 65m, 4L },
                    { 4L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.", 1L, 50m, 3L },
                    { 3L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.", 1L, 50m, 3L },
                    { 2L, "Deze suite heeft een balkon, een eigen ingang en een zithoek.", 1L, 80m, 2L },
                    { 29L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning", 6L, 80m, 4L },
                    { 30L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 6L, 80m, 4L },
                    { 31L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 7L, 110m, 1L },
                    { 32L, "Deze suite heeft een balkon, een eigen ingang en een zithoek en airconditioning.", 7L, 95m, 2L },
                    { 60L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 12L, 70m, 4L },
                    { 59L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 12L, 60m, 4L },
                    { 58L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.", 12L, 45m, 5L },
                    { 57L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 12L, 80m, 2L },
                    { 56L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 12L, 80m, 2L },
                    { 55L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 11L, 70m, 4L },
                    { 54L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 11L, 70m, 4L },
                    { 53L, "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 11L, 50m, 5L },
                    { 52L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 11L, 85m, 2L },
                    { 51L, "Deze suite heeft een balkon,een eigen ingang en een zithoek.", 11L, 95m, 2L },
                    { 50L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 10L, 90m, 4L },
                    { 49L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 10L, 90m, 4L },
                    { 48L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.", 10L, 70m, 5L },
                    { 62L, "Tweepersoonskamer met 2 eenpersoonsbedden,betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.", 13L, 60m, 5L },
                    { 47L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 10L, 80m, 3L },
                    { 45L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 9L, 85m, 4L },
                    { 44L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ", 9L, 85m, 4L },
                    { 43L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.", 9L, 70m, 5L },
                    { 42L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning", 9L, 70m, 3L },
                    { 41L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 9L, 90m, 1L },
                    { 40L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning.", 8L, 80m, 4L },
                    { 39L, "Deze driepersoonskamer is voorzien van een zithoek,airconditioning en een betegelde / marmeren vloer  airconditioning", 8L, 80m, 4L },
                    { 38L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning", 8L, 70m, 5L },
                    { 37L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 8L, 100m, 1L },
                    { 36L, "Deze suite heeft een balkon,een betegelde / marmeren vloer en airconditioning.", 8L, 100m, 1L },
                    { 35L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning.", 7L, 85m, 4L },
                    { 34L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning.", 7L, 85m, 4L },
                    { 33L, "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.", 7L, 75m, 5L },
                    { 46L, "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.", 10L, 105m, 1L },
                    { 125L, "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning", 25L, 110m, 4L }
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
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
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
