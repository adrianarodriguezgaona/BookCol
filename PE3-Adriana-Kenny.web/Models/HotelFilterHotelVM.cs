using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class HotelFilterHotelVM
    {
        public string Stad { get; set; }
        public int AantalSterren { get; set; }
        public string SoortKamer { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<City> Steden { get; set; }
    }
}
