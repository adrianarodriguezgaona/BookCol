using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Hotels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long HotelId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(1)]
        public int Stars { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]       
        public int NmbrOfRooms{ get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        // navigation property

        public City City { get; set; }


    }
}
