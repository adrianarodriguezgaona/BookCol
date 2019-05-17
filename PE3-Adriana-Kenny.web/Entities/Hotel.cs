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
   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long CityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(1)]
        public int Stars { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }

        [Required]  
        public int NmbrOfRooms{ get; set; }

        
        public string Photo { get; set; }

        [Required]
        public string Description { get; set; }

        public string Faciliteiten { get; set; }

        public City City { get; set; }

        public List<Room> Rooms { get; set; }

    }
}
