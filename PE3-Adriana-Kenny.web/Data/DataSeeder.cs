using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)

        {

            // cities

            modelBuilder.Entity<City>().HasData(

                new City
                {
                    Id = 1,
                    Name = "Bogota",
                    Description = "Ga je naar Colombia, dan moet je zeker een bezoek brengen aan de hoofdstad van Colombia." +
                " De hoofdstad van Colombia ligt in het midden van het land en wordt Bogota of Bogotá genoemd. Het is waarschijnlijk het eerste wat je ziet in Colombia, en dat bevalt meteen goed. " +
                "Het is een gigantische stad, maar heeft leuke, sfeervolle plekjes",
                    Photo = "Bogota.jpg"
                },

                new City
                {
                    Id = 2,
                    Name = "Cartagena",
                    Description = "Wanneer je een bezoek aan Colombia brengt mag een bezoek aan Cartagena zeker niet ontbreken. " +
                    "Het is een van de bekendste steden aan de Caribische kust, een sprookjesachtige stad met romantiek, legendes en prachtig bewaard gebleven, eeuwen-oude koloniale oud centrum. Door de doolhof van geplaveide straatjes," +
                    " gekleurde balkons en enorme kerken staat Cartagena op de Unesco World Heritage lijst.",
                    Photo = "Cartagena.jpg"
                },

                new City
                {
                    Id = 3,
                    Name = "Medellin",
                    Description = "Gelegen in een smalle vallei met een schitterende " +
                    "skyline is Medellin een van de mooist gelegen steden in Colombia. Het aangename klimaat geeft de stad zijn bijnaam –" +
                    " De Stad van de Eeuwige Lente",
                    Photo = "Medellin.jpg"
                },

                  new City
                  {
                      Id = 4,
                      Name = "San Andres",
                      Description = "Colombia beschikt over verschillende eilanden.Denk bijvoorbeeld aan eilandgroepen als de Rosario -" +
                      " eilanden en de San Bernardo - eilanden.Ook heeft Colombia verschillende eilanden die niet direct voor de Colombiaanse " +
                      "kust liggen, maar wel een onderdeel van het land zijn.Een goed voorbeeld hiervan is San Andres wat in de Caribische Zee ligt",
                      Photo = "SanAndres.jpg"

                  },

                   new City
                   {
                       Id = 5,
                       Name = "Santa Marta",
                       Description = "Colombia beschikt over verschillende eilanden.Denk bijvoorbeeld aan eilandgroepen als de Rosario -" +
                      " eilanden en de San Bernardo - eilanden.Ook heeft Colombia verschillende eilanden die niet direct voor de Colombiaanse " +
                      "kust liggen, maar wel een onderdeel van het land zijn.Een goed voorbeeld hiervan is San Andres wat in de Caribische Zee ligt",
                       Photo = "SantaMarta.jpg"

                   });



            modelBuilder.Entity<Hotel>().HasData(


                // hotels Bogota -----------------------------------------------------------------------

                new Hotel
                {
                    Id = 1,
                    Name = "Ibis Bogota Museo ",
                    Address = "Transversal 6 No 27 - 85",
                    Stars = 4,
                    NmbrOfRooms = 5,
                    Description = "Dit hotel ligt in Centro International, binnen 2 km afstand van " +
                                                "Nationaal Museum en Goudmuseum. Ook Monserrate en Amerikaanse ambassade liggen binnen 5 km afstand.",
                    Photo = "IbisBogota.jpg",
                    CityId = 1

                },

                  new Hotel
                  {
                      Id = 2,
                      Name = "Selina Parque 93",
                      Address = "Calle 95 Numero 13-35, Chapinero,",
                      Stars = 3,
                      NmbrOfRooms = 5,
                      Description = "Selina Parque 93 Bogota ligt in Bogotá en beschikt over een terras en een gemeenschappelijke lounge. Dit 3-sterrenhotel " +
                      "biedt een 24-uursreceptie, een gedeelde keuken en gratis WiFi. De accommodatie is rookvrij en ligt op 2,5 km van T Zone..",
                      Photo = "SelinaParque.jpg",
                      CityId = 1,



                  },


                     new Hotel
                     {
                         Id = 3,
                         Name = "Deportel Bogotá",
                         Address = "Cra 71 No 69-04, Engativa",
                         Stars = 4,
                         NmbrOfRooms = 5,
                         Description = "Deportel Bogotá ligt op 100 m van het La Europa Park en op 3 km van het" +
                         "Simón Bolívar Park. Het beschikt over een gemeenschappelijke lounge en gratis WiFi in alle ruimtes.",
                         Photo = "Deportel.jpg",
                         CityId = 1,

                     },


                        new Hotel
                        {
                            Id = 4,
                            Name = "Four Seasons Hotel Casa Medina",
                            Address = "Avenida Carrera 7 # 69a-22, Chapinero",
                            Stars = 3,
                            NmbrOfRooms = 5,
                            Description = "Ga voor een sterrenbehandeling en geniet van service van wereldklasse in " +
                            "Four Seasons Hotel Casa Medina Bogotavan T Zone..",
                            Photo = "FourSeasonsCasaMedina",
                            CityId = 1,

                        },

                           new Hotel
                           {
                               Id = 5,
                               Name = "Expo Suites Parque Bavaria",
                               Address = "Avenida Carrera 7 # 69a-22, Chapinero",
                               Stars = 3,
                               NmbrOfRooms = 5,
                               Description = " Een van onze bestsellers in Bogota!" +
                                "Expo Suites Parque Central Bavaria ligt in de financiële wijk van Bogotá.Het biedt een trendy," +
                              "paars interieur met witte orchideeën en kamers met gratis WiFi.",

                               Photo = "ExpoSuitesParque",
                               CityId = 1,
                           },


                              // hotels Cartagena --------------------------------------------------

                              new Hotel
                              {
                                  Id = 6,
                                  Name = "Hotel Stil Cartagena",
                                  Address = "Calle 34 # 11-15. Plazoleta Telecom, La Matuna",
                                  Stars = 3,
                                  NmbrOfRooms = 5,
                                  Description = "Hotel Stil biedt ruime accommodatie met gratis WiFi en een pendeldienst" +
                                  " van/naar de luchthaven. Het ligt in het historische centrum van Cartagena, dicht bij " +
                                  "India Catalina in het traditionele stadsdeel La Matuta.",
                                  Photo = "StilCartagena.jpg",
                                  CityId = 2,

                              },

                             new Hotel
                             {
                                 Id = 7,
                                 Name = "Hotel Costa del Sol",
                                 Address = "Bocagrande, Avenida 1A # Calle 9A Esquina, Bocagrande",
                                 Stars = 3,
                                 NmbrOfRooms = 5,
                                 Description = "Costa del Sol ligt aan het strand van Bocagrande." +
                                  " De accommodatie biedt gratis WiFi en een zwembad op het dak met" +
                                  " panoramisch uitzicht op de baai en de ommuurde stad Cartagena.",
                                 Photo = "CostaDelSol.jpg",
                                 CityId = 2,

                             },

                             
                               new Hotel
                               {
                                   Id = 8,
                                   Name = "Hotel Zi One Luxury",
                                   Address = "Calle 5 # 3 14 Bocagrande, Bocagrande,",
                                   Stars = 4,
                                   NmbrOfRooms = 5,
                                   Description = "Hotel Zi One in Cartagena de Indias beschikt over " +
                                   "een buitenbad en kamers met gratis WiFi en uitzicht op zee. " +
                                   "De 4-sterrenaccommodatie ligt op 2,8 km van het Paleis van de Inquisitie," +
                                   " het Goudmuseum van Cartagena en het Bolivar-park.",
                                   Photo = "ZiOneLuxury.jpg",
                                   CityId = 2,

                               },

                               new Hotel
                               {
                                   Id = 9,
                                   Name = "Hotel Caribe By Faranda",
                                   Address = "Bocagrande, Carrera. 1a # 2-87, Bocagrande",
                                   Stars = 5,
                                   NmbrOfRooms = 5,
                                   Description = "Dit luxueuze hotel aan het Caribische strand heeft een " +
                                   "buitenzwembad, stijlvolle koloniale architectuur en spafaciliteiten. " +
                                   "U kunt massages en duiktrips reserveren. WiFi is gratis beschikbaar.",
                                   Photo = "CaribeByFaranda.jpg",
                                   CityId = 2,

                               },


                               new Hotel
                               {
                                   Id = 10,
                                   Name = "Bastión Luxury Hotel",
                                   Address = "Centro historico, Calle del Sargento No. 6 - 87, Centro",
                                   Stars = 5,
                                   NmbrOfRooms = 5,
                                   Description = "Dit moderne hotel ligt in het hart van de ommuurde stad Cartagena." +
                                   " Het bevindt zich in een gerenoveerd gebouw uit de 16e eeuw en beschikt " +
                                   "over een dakterras met een zwembad en een gedeelde woonkamer. Het beschikt ook" +
                                   " over een eigen gastronomisch restaurant en gratis WiFi.",
                                   Photo = "BastionLuxury.jpg",
                                   CityId = 2,

                               },
                               // Hotels Medellin__---------------------
                               new Hotel
                               {
                                  Id = 11,
                                  Name = "Hotel San Fernando Plaza" , 
                                  Address = "Carrera 42 A No. 1 - 15, El Poblado, Medellín", 
                                  Stars = 5,
                                  NmbrOfRooms = 5, 
                                  CityId = 3, 
                                  Description = "San Fernando Plaza beschikt over een verwarmd buitenzwembad, een spa en een fitnesscentrum." +
                                  "Het biedt luxe accommodatie in El Poblado, de exclusieve financiële en commerciële wijk van Medellin.Het hotel heeft ook een restaurant en een bar.", 
                                  Photo ="SanFernandoPlaza.jpg",  
                                  },
                              new Hotel{
                                  Id = 12,
                                  Name = "Hotel Suite 45",
                                  Address ="Carrera 45 # 49-35, La Candelaria, Medellín.",
                                  Stars =3,
                                  NmbrOfRooms =5,
                                  CityId = 3,
                                  Description = "Hotel Suite 45 ligt in Medellin, op slechts 1 km van het metrostation Parque Berrio en biedt kamers met gratis WiFi en kabel-tv. " + 
                                  "Bij de accommodatie is gratis parkeergelegenheid beschikbaar. Het centrale plein en het Botero-plein liggen op 1 km afstand.",
                                  Photo ="Suite45.jpg",
                              },

                              new Hotel{
                                  Id = 13 ,
                                  Name = "Hotel Medellin 33",
                                  Address = "3324 Carrera 65, Laureles, Medellín",
                                  Stars = 3,
                                  NmbrOfRooms = 5 ,
                                  CityId = 3,
                                  Description = "Hotel Medellin 33 ligt op 2,9 km van Pueblito Paisa, in Medellín.Het biedt een aantal voorzieningen, waaronder een buitenzwembad, een fitnesscentrum en een terras." +
                                  "Tot de faciliteiten van deze accommodatie behoren een restaurant, een 24 - uursreceptie, een gemeenschappelijke lounge en gratis WiFi. De accommodatie beschikt over een hot tub, entertainmentpersoneel en roomservice.",
                                  Photo = "Medellin33.jpg",
                              },

                              new Hotel{
                                  Id = 14 ,
                                  Name = "Selina Medellin",
                                  Address ="Carrera 32d # 9-17, El Poblado, Medellín." ,
                                  Stars = 3,
                                  NmbrOfRooms = 5 ,
                                  CityId = 3,
                                  Description = "Selina Medellin ligt in Medellín en biedt een terras, een gemeenschappelijke lounge, een restaurant, een 24 - uursreceptie," +
                                  " een gemeenschappelijke keuken en gratis WiFi. Voor een drankje kunt u terecht bij de bar.",
                                  Photo = "SelinaMedellin.jpg",
                              },

                              new Hotel{
                                  Id = 15 ,
                                  Name = "HOTEL MED 70" ,
                                  Address ="CR 69 46B 34, Laureles, Medellín.",
                                  Stars = 4 ,
                                  NmbrOfRooms = 5 ,
                                  CityId = 3,
                                  Description = "Mooie, schone kamers met een moderne badkamer. Op loopafstand van het metrostation en om de hoek van een gezellige uitgaansstraat in Medellin met leuke restaurants" +
                                  " e.d.waar weinig toeristen komen en je dus meer tussen de locals zit. Top locatie!",

                                  Photo = "Med70.jpg",
                              },

                              // Hotels San Andres---------------------------------------------------------------------


                               new Hotel{
                                    Id = 16 ,
                                    Name = "Viajero San Andres Hostel" ,
                                    Address = "Av. 20 de Julio Nº 3A - 122, San Andrés." ,
                                    Stars = 4,
                                    NmbrOfRooms = 5,
                                    CityId = 4,
                                    Description = "San Andrés Hostel heeft kamers met airconditioning." +
                                    "Het ligt op slechts 5 minuten lopen van het strand en de zee van 7 kleuren.Er is een discobar bij de accommodatie en er zijn duiklessen beschikbaar. ",
                                    Photo = "ViajeroSanandresHostel.jpg ",
                               },

                               new Hotel{
                                    Id = 17 ,
                                    Name = "Le Castel Blanc Hotel Boutique",
                                    Address = "Calle 3 18 - 71 , San Andrés.",
                                    Stars = 5,
                                    NmbrOfRooms = 5,
                                    CityId = 4,
                                    Description = "Deze elegante villa in mediterrane stijl heeft een buitenzwembad." +
                                    "U kunt er verblijven in kamers met airconditioning en gratis WiFi. Er is ook gratis privéparkeergelegenheid beschikbaar.",
                                    Photo ="LeCastelBlanc.jpg"
                                },

                               new Hotel{
                                    Id = 18 ,
                                    Name = "Hotel Cocoplum Beach",
                                    Address = "Vía a San Luis # 43-39, San Andrés.",
                                    Stars = 4 ,
                                    NmbrOfRooms = 5 ,
                                    CityId = 4,
                                    Description = "Hotel Cocoplum Beach ligt aan het Cocoplum - strand, een van de mooiste stranden van San Andrés. Het biedt een zwembad, een spa en een restaurant met uitzicht op zee. Er is gratis WiFi beschikbaar in de gemeenschappelijke ruimtes en het hotel serveert ontbijt.",
                                    Photo = "CocoplumBeach.jpg",
                                },


                               new Hotel{
                                  Id = 19 ,
                                  Name = "San Luis Place By El Dorado" ,
                                  Address = "Via San Luis, Antes de Rocky Cay Bay,  San Andrés.",
                                  Stars = 5,
                                  NmbrOfRooms = 5,
                                  CityId = 4,
                                  Description = "San Luis Place By El Dorado ligt in San Andrés, in de omgeving van de eilanden San Andres en Providencia, " +
                                  "op nog geen 3,5 km van San Andrés-baai, en beschikt over een zonneterras en een eigen strand.",
                                  Photo = "ElDorado.jpg",
                                },

                               new Hotel{
                                    Id = 20 ,
                                    Name = "Hostal Rohomar",
                                    Address = "Via san luis, 880001 San Andrés.",
                                    Stars = 3,
                                    NmbrOfRooms = 5,
                                    CityId = 4,
                                    Description = "Hostal Rohomar biedt gratis WiFi en uitzicht op zee in San Andrés." +
                                    " Het pension ligt op ongeveer 2,6 km van de baai van San Andres en op 3,5 km van North End. " +
                                    "Lokale bezienswaardigheden zoals Spratt Bight en The Hill zijn bereikbaar binnen respectievelijk 3,7 km en 1,9 km.",
                                    Photo = "HostalRohomar.jpg"
                                },

            // Hotels Santa Marta -----------------------------------------------------

                                 new Hotel
                                 {
                                     Id = 21,
                                     Name = "Hotel Catedral Plaza",
                                     Address = "Calle 16 # 5-17, Centro Histórico",
                                     Stars = 4,
                                     NmbrOfRooms = 5,
                                     Description = "Hotel Catedral Plaza ligt in Santa Marta in de" +
                                     " regio Magdalena, op 5 km van het strand van El Rodadero. " +
                                     "Het beschikt over een buitenbad en een zonneterras. " +
                                     "Gasten kunnen genieten van de bar bij de accommodatie, " +
                                     "en er wordt dagelijks een Amerikaans ontbijt aangeboden.",
                                     Photo = "CatedralPlaza.jpg",
                                     CityId = 5,

                                 },


                                   new Hotel
                                   {
                                       Id = 22,
                                       Name = "Decameron Galeon",
                                       Address = "Km 17 vía a Cienaga",
                                       Stars = 3,
                                       NmbrOfRooms = 5,
                                       Description = "Het hotel ligt op slechts 100 meter van het strand van " +
                                       "Pozos Colorados en beschikt over een zwembad, 2 tennisbanen en een discobar. " +
                                       "U kunt dineren in een restaurant in de vorm van een piratenschip.",
                                       Photo = "DecameronGaleon.jpg",
                                       CityId = 5,

                                   },

                                    new Hotel
                                    {
                                        Id = 23,
                                        Name = "Irotama Resort",
                                        Address = "Km 14 via a Cienaga. Bello Horizonte",
                                        Stars = 5,
                                        NmbrOfRooms = 5,
                                        Description = "Het Irotama Resort ligt op 100 meter van het strand en " +
                                        "biedt op het terrein zelf watersportactiviteiten, 3 buitenzwembaden en " +
                                        "een spa- en fitnesscentrum. Er is WiFi beschikbaar. Er worden ook activiteiten " +
                                        "voor kinderen georganiseerd. Er is bovendien gratis vervoer vanaf de luchthaven mogelijk."
                                        Photo = "IrotamaResort.jpg",
                                        CityId = 5,

                                    },


                                       new Hotel
                                       {
                                           Id = 24,
                                           Name = "Bunsizanisi Hotel",
                                           Address = "Calle 11a No 6-136, El Rodadero, Cerro la Llorona",
                                           Stars = 3,
                                           NmbrOfRooms = 5,
                                           Description = "Bunsizanisi Hotel ligt in de wijk El Rodadero van " +
                                           "Santa Marta en beschikt over kamers met gratis WiFi. Tot de verschillende " +
                                           "faciliteiten van deze accommodatie behoren een buitenzwembad, een tuin en " +
                                           "een terras. De accommodatie ligt op 700 m van het strand El Rodadero.",
                                           Photo = "Bunsizanisi.jpg",
                                           CityId = 5,

                                       },


                                           new Hotel
                                           {
                                               Id = 25,
                                               Name = "Hilton Garden Inn Santa Marta",
                                               Address = "Carrera 1C No. 24-04",
                                               Stars = 4,
                                               NmbrOfRooms = 5,
                                               Description = "Hilton Garden Inn Santa Marta bevindt zich in Santa Marta, " +
                                               "en biedt een buitenzwembad, een fitnesscentrum, een tuin en gratis WiFi. " +
                                               "De accommodatie ligt op 6 km van het strand van El Rodadero, op 200 meter " +
                                               "van de jachthaven van Santa Marta en op 1 km van de kathedraal van Santa Marta." +
                                               " Het hotel beschikt over een gemeenschappelijke lounge.",
                                               Photo = "HiltonGardenInn.jpg",
                                               CityId = 5,

                                           });

            modelBuilder.Entity<Roomtype>().HasData(

                new Roomtype{
                Id = 1 ,
                Type ="Suite met Uitzicht op Zee",
                },
                new Roomtype
                {
                Id = 2 ,
                Type ="Suite",
                },
                new Roomtype{
                Id = 3,
                Type ="Tweepersoonskamer",
                },
                new Roomtype{
                Id = 4 ,
                Type ="Driepersoonskamer",
                },
                new Roomtype{
                Id = 5,
                Type ="Tweepersoonskamer met 2 aparte bedden",

                });

            modelBuilder.Entity<Room>().HasData(

                new Room
                {
                    Id = 1,
                    HotelId = 1,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon een eigen ingang en een zithoek.",
                    PriceNight = 80,
                },

                new Room
                {
                    Id = 2,
                    HotelId = 1,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon, een eigen ingang en een zithoek.",
                    PriceNight = 80,
                },


                new Room {
                    Id = 3,
                    HotelId = 1,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.",
                    PriceNight = 50,
                },
                new Room
                {
                    Id = 4,
                    HotelId = 1,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.",
                    PriceNight = 50,
                },
                new Room
                {
                    Id = 5,
                    HotelId = 1,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.",
                    PriceNight = 65,
                },

                new Room{
                Id = 6,
                HotelId = 2,
                RoomTypeId = 2,
                Description ="Deze suite heeft een balkon, een eigen ingang en een zithoek",
                PriceNight = 90,
                },


                new Room{
                Id = 7,
                HotelId = 2,
                RoomTypeId = 3,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.",
                PriceNight = 40,
                },

                new Room{
                Id = 8,
                HotelId = 2,
                RoomTypeId = 3,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.",
                PriceNight = 40,
                },

                new Room{
                Id = 9,
                HotelId = 2,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.",
                PriceNight = 60
                },
                new Room
                {
                Id = 10,
                HotelId = 2,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer.",
                PriceNight = 60,
                },

                new Room
                {
                    Id = 11,
                    HotelId = 3,
                    RoomTypeId = 3,
                    Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.",
                    PriceNight = 60
                    },
                new Room{
                    Id = 12,
                    HotelId = 3,
                    RoomTypeId = 5,
                    Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer ",
                    PriceNight = 70
                },
                new Room{
                Id = 13,
                HotelId = 3,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer",
                PriceNight = 70
                },
                new Room{
                Id = 14,
                HotelId = 3,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 80
                },
                new Room
                {
                Id = 15,
                HotelId = 3,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 80
                },

                new Room
                {
                    Id = 16,
                    HotelId = 4,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek",
                    PriceNight = 80
                },
                new Room{
                    Id = 17,
                    HotelId = 4,
                    RoomTypeId = 5,
                    Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer ",
                    PriceNight = 55
                    },
                new Room{
                    Id = 18,
                    HotelId = 4,
                    RoomTypeId = 5,
                    Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer",
                    PriceNight = 55
                },
                new Room{
                Id = 19,
                HotelId = 4,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 65
                },
                new Room{
                Id = 20,
                HotelId = 4,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 65
                },

                new Room
                {
                    Id = 21,
                    HotelId = 5,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                    PriceNight = 95
                },
                new Room{
                Id = 22,
                HotelId = 5,
                RoomTypeId = 2,
                Description ="Deze suite heeft een balkon, een eigen ingang en een zithoek ",
                PriceNight = 95
                },
                new Room{
                Id = 23,
                HotelId = 5,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer",
                PriceNight = 65
                },
                new Room{
                Id = 24,
                HotelId = 5,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 75
                },
                new Room{
                Id = 25,
                HotelId = 5,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer",
                PriceNight = 75
                },
                new Room
                {
                    Id = 26,
                    HotelId = 6,
                    RoomTypeId = 1,
                    Description ="Deze suite heeft een balkon,een betegelde / marmeren vloer en airconditioning",
                    PriceNight = 100
                },
                new Room{
                Id = 27,
                HotelId = 6,
                RoomTypeId = 2,
                Description ="Deze suite heeft een balkon, een eigen ingang en een zithoek en  airconditioning ",
                PriceNight = 90
                },
                new Room{
                Id = 28,
                HotelId = 6,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning",
                PriceNight = 70
                },
                new Room{
                Id = 29,
                HotelId = 6,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning",
                PriceNight = 80
                },
                new Room{
                Id = 30,
                HotelId = 6,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                PriceNight = 80
                },
                new Room
                {
                Id = 31,
                HotelId = 7,
                RoomTypeId = 1,
                Description ="Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                PriceNight = 110
                },
                new Room{
                Id = 32,
                HotelId = 7,
                RoomTypeId = 2,
                Description ="Deze suite heeft een balkon, een eigen ingang en een zithoek en airconditioning.",
                PriceNight = 95
                },
                new Room{
                Id = 33,
                HotelId = 7,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.",
                PriceNight = 75
                },
                new Room{
                Id = 34,
                HotelId = 7,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning.",
                PriceNight = 85
                },
                new Room{
                Id = 35,
                HotelId = 7,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning.",
                PriceNight = 85
                },
                new Room
                {
                    Id = 36,
                    HotelId = 8,
                    RoomTypeId = 1,
                    Description ="Deze suite heeft een balkon,een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 100
                },
                new Room{
                Id = 37,
                HotelId = 8,
                RoomTypeId = 1,
                Description ="Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                PriceNight = 100
                },
                new Room{
                Id = 38,
                HotelId = 8,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning",
                PriceNight = 70
                },
                new Room{
                Id = 39,
                HotelId = 8,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek,airconditioning en een betegelde / marmeren vloer  airconditioning",
                PriceNight = 80
                },
                new Room{
                Id = 40,
                HotelId = 8,
                RoomTypeId = 4,
                 Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning.",
                PriceNight = 80
                },

                new Room
                {
                    Id = 41,
                    HotelId = 9,
                    RoomTypeId = 1,
                    Description ="Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 90
                },
                new Room{
                Id = 42,
                HotelId = 9,
                RoomTypeId = 3,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                 PriceNight = 70
                },
                new Room{
                Id = 43,
                HotelId = 9,
                RoomTypeId = 5,
                Description ="Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.",
                PriceNight = 70
                },
                new Room{
                Id = 44,
                HotelId = 9,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                PriceNight = 85
                },
                new Room{
                Id = 45,
                HotelId = 9,
                RoomTypeId = 4,
                Description ="Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                PriceNight = 85
                },
                new Room
                {
                    Id = 46,
                    HotelId = 10,
                    RoomTypeId = 1,
                    Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 105
                },
                new Room
                {
                    Id = 47,
                    HotelId = 10,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 48,
                    HotelId = 10,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.",
                    PriceNight = 70
                },
                new Room
                {
                    Id = 49,
                    HotelId = 10,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 50,
                    HotelId = 10,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 90
                },
                 new Room
                 {
                     Id = 51,
                     HotelId = 11,
                     RoomTypeId = 2,
                     Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                     PriceNight = 95
                 },
                new Room
                {
                    Id = 52,
                    HotelId = 11,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                    PriceNight = 85
                },
                new Room
                {
                    Id = 53,
                    HotelId = 11,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 50
                },
                new Room
                {
                    Id = 54,
                    HotelId = 11,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 70
                },
                new Room
                {
                    Id = 55,
                    HotelId = 11,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 70
                },

                new Room
                {
                    Id = 56,
                    HotelId = 12,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 57,
                    HotelId = 12,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 58,
                    HotelId = 12,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer airconditioning.",
                    PriceNight = 45
                },
                new Room
                {
                    Id = 59,
                    HotelId = 12,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 60
                },
                new Room
                {
                    Id = 60,
                    HotelId = 12,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 70
                },

                 new Room
                 {
                     Id = 61,
                     HotelId = 13,
                     RoomTypeId = 2,
                     Description = "Deze suite heeft een balkon,een eigen ingang en een zithoek.",
                     PriceNight = 85
                 },
                new Room
                {
                    Id = 62,
                    HotelId = 13,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden,betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 60
                },
                new Room
                {
                    Id = 63,
                    HotelId = 13,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden ,betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 60
                },
                new Room
                {
                    Id = 64,
                    HotelId = 13,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 75
                },
                new Room
                {
                    Id = 65,
                    HotelId = 13,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 75
                },

                 new Room
                 {
                     Id = 66,
                     HotelId = 14,
                     RoomTypeId = 3,
                     Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                     PriceNight = 85
                 },
                new Room
                {
                    Id = 67,
                    HotelId = 14,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 68,
                    HotelId = 14,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 69,
                    HotelId = 14,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 70,
                    HotelId = 14,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 100
                },
                 new Room
                 {
                     Id = 71,
                     HotelId = 15,
                     RoomTypeId = 3,
                     Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                     PriceNight = 55
                 },
                new Room
                {
                    Id = 72,
                    HotelId = 15,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 73,
                    HotelId = 15,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 74,
                    HotelId = 15,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 75,
                    HotelId = 15,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 100
                },
                
                 new Room
                 {
                     Id = 76,
                     HotelId = 16,
                     RoomTypeId = 3,
                     Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                     PriceNight = 45
                 },
                new Room
                {
                    Id = 77,
                    HotelId = 16,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.",
                    PriceNight = 45
                },
                new Room
                {
                    Id = 78,
                    HotelId = 16,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 50
                },
                new Room
                {
                    Id = 79,
                    HotelId = 16,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 70
                },
                new Room
                {
                    Id = 80,
                    HotelId = 16,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 70
                },

                 new Room
                 {
                     Id = 81,
                     HotelId = 17,
                     RoomTypeId = 1,
                     Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                     PriceNight = 140
                 },
                new Room
                {
                    Id = 82,
                    HotelId = 17,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning.",
                    PriceNight = 70
                },
                new Room
                {
                    Id = 83,
                    HotelId = 17,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 75
                },
                new Room
                {
                    Id = 84,
                    HotelId = 17,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 85,
                    HotelId = 17,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 86,
                    HotelId = 18,
                    RoomTypeId = 1,
                    Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 150
                },
                new Room
                {
                    Id = 87,
                    HotelId = 18,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 120
                },
                new Room
                {
                    Id = 88,
                    HotelId = 18,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 75
                },
                new Room
                {
                    Id = 89,
                    HotelId = 18,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 95
                },
                new Room
                {
                    Id = 90,
                    HotelId = 18,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 95
                },

                new Room
                {
                    Id = 91,
                    HotelId = 19,
                    RoomTypeId = 1,
                    Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 120
                },
                new Room
                {
                    Id = 92,
                    HotelId = 19,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 93,
                    HotelId = 19,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 85
                },
                new Room
                {
                    Id = 94,
                    HotelId = 19,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 95
                },
                new Room
                {
                    Id = 95,
                    HotelId = 19,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 95
                },
                 new Room
                 {
                     Id = 96,
                     HotelId = 20,
                     RoomTypeId = 1,
                     Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                     PriceNight = 180
                 },
                new Room
                {
                    Id = 97,
                    HotelId = 20,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 150
                },
                new Room
                {
                    Id = 98,
                    HotelId = 20,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 99,
                    HotelId = 20,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 110
                },
                new Room
                {
                    Id = 100,
                    HotelId = 20,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 110
                },
                 new Room
                 {
                     Id = 101,
                     HotelId = 21,
                     RoomTypeId = 1,
                     Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                     PriceNight = 150
                 },
                new Room
                {
                    Id = 102,
                    HotelId = 21,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 130
                },
                new Room
                {
                    Id = 103,
                    HotelId = 21,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 104,
                    HotelId = 21,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 105,
                    HotelId = 21,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 106,
                    HotelId = 22,
                    RoomTypeId = 1,
                    Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 170
                },
                new Room
                {
                    Id = 107,
                    HotelId = 22,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 150
                },
                new Room
                {
                    Id = 108,
                    HotelId = 22,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 109,
                    HotelId = 22,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer  airconditioning ",
                    PriceNight = 105
                },
                new Room
                {
                    Id = 110,
                    HotelId = 22,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 105
                },

                 new Room
                 {
                     Id = 111,
                     HotelId = 23,
                     RoomTypeId = 1,
                     Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                     PriceNight = 160
                 },
                new Room
                {
                    Id = 112,
                    HotelId = 23,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 113,
                    HotelId = 23,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 114,
                    HotelId = 23,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 115,
                    HotelId = 23,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 110
                },
                 new Room
                 {
                     Id = 116,
                     HotelId = 24,
                     RoomTypeId = 1,
                     Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                     PriceNight = 130
                 },
                new Room
                {
                    Id = 117,
                    HotelId = 24,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 118,
                    HotelId = 24,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 119,
                    HotelId = 24,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ",
                    PriceNight = 80
                },
                new Room
                {
                    Id = 120,
                    HotelId = 24,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 100
                },
                new Room
                {
                    Id = 121,
                    HotelId = 25,
                    RoomTypeId = 1,
                    Description = "Deze suite heeft een balkon, een betegelde / marmeren vloer en airconditioning.",
                    PriceNight = 160
                },
                new Room
                {
                    Id = 122,
                    HotelId = 25,
                    RoomTypeId = 2,
                    Description = "Deze suite heeft een balkon,een eigen ingang, een zithoek en airconditioning",
                    PriceNight = 140
                },
                new Room
                {
                    Id = 123,
                    HotelId = 25,
                    RoomTypeId = 5,
                    Description = "Tweepersoonskamer met 2 eenpersoonsbedden, betegelde / marmeren vloeren en een kitchenette met keukengerei.Gedeelde badkamer.",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 124,
                    HotelId = 25,
                    RoomTypeId = 3,
                    Description = "Tweepersoonskamer met betegelde / marmeren vloeren en een kitchenette met keukengerei en airconditioning ",
                    PriceNight = 90
                },
                new Room
                {
                    Id = 125,
                    HotelId = 25,
                    RoomTypeId = 4,
                    Description = "Deze driepersoonskamer is voorzien van een zithoek, airconditioning en een betegelde / marmeren vloer airconditioning",
                    PriceNight = 110
                });

        }
    }
}

