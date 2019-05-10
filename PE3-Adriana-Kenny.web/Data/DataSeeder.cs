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
            
        }
    }
}

