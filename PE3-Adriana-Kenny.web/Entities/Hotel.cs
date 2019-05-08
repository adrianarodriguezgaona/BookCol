using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long HotelId { get; set; }

        public string Name { get; set; }

     public int Stars { get; set; }

        public int CityId { get; set; }

        public string Address { get; set; }

        public int NmbrOfRooms{ get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

      

    }
}
