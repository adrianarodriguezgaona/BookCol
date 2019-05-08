using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [ForeignKey("Client")]
        public long ClientId { get; set; }

        [MaxLength(1)]
         public int NmbrOfPeople { get; set; }

        [ForeignKey("Room")]
        public long RoomId { get; set; }

        //navigation properties
        public List<Booking> Bookings { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }

    }
}
