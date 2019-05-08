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

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public long CustomerId { get; set; }

         public int NmbrOfPeople { get; set; }

        public long RoomId { get; set; }

        //navigation properties
        public List<Booking> RoomBookings { get; set; }
        public Client ClientBooking { get; set; }



    }
}
