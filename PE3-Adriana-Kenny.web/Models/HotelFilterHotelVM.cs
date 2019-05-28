using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class HotelFilterHotelVM
    {
        public long CityId { get; set; }
        public int AmountStars { get; set; }
        public string RoomType { get; set; }
        public List<Hotel> Hotels { get; set; }
        public List<City> Cities { get; set; }
        public List<bool> StarsChecked { get; set; }
    }
}
