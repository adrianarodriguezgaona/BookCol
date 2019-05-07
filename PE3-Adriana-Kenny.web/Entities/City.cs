using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class City
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }



        // navigation property

        public List<Hotels> Hotels { get; set; }

    }
}
