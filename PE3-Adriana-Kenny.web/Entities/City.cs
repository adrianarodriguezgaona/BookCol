using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class City :BaseEntity <long>
    {
      
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Photo { get; set; }

        // navigation property

        public List<Hotel> Hotels { get; set; }

    }
}
