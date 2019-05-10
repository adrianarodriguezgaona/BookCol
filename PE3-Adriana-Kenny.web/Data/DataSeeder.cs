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
                           });
        }
    }
}

