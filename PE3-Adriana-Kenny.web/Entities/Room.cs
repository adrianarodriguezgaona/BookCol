using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoomId { get; set; }

        public string Description { get; set; }

   
        public decimal PriceNight { get; set; }


        public int HotelId { get; set; }


        public long RoomTypeId{ get; set; }
    }
}
