using Microsoft.AspNetCore.Http;
using PE3_Adriana_Kenny.web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Models
{
    public class AdminIndexVM : Hotel
    {
        public List<Hotel> Hotels { get; set; }
        public List<City> CityList { get; set; }
        public IFormFile ImageToUpload { get; set; }
        public List<Roomtype> Roomtypes { get; set; }
        public int AmountOfRooms { get; set; }
        public Hotel Hotel { get; set; }
    }
}
