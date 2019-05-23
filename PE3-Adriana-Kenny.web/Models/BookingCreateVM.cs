using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class BookingCreateVM 
    {
      

        [Display(Name ="Inchecken")]
        [Required(ErrorMessage = "Geef een incheckdatum a.u.b.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Display(Name = "Uitchecken")]
        [Required(ErrorMessage = "Geef een uitcheckdatum a.u.b.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Display(Name ="Klantnr")]
        [Required(ErrorMessage = "Geef uw klantnummer a.u.b")]
        [Range (1,200)]
        public long ClientId { get; set; }

        [Display(Name = "Kamernummer")]
        [Required(ErrorMessage = "Kies het kamernummer a.u.b")]
        public long RoomId { get; set; }

        [Display(Name = "Aantal personen")]
        [Required(ErrorMessage = "Geef het aantal personen a.u.b")]
        [Range (1,3)]
        public int NmbrOfPeople { get; set; }

        public List<Room>Rooms { get; set; }
        public List<Hotel>Hotels { get; set; }
        
    }
}
