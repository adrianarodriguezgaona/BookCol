using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PE3_Adriana_Kenny.web.Entities
{
    public class Client
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required]
        public string Address { get; set; }        

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string Community { get; set; }

        [Required]
        public string Country { get; set; }
        
        [Required]
        public string  Email { get; set; }

        // navigation property
        public List<Booking> ClientBookings { get; set; }

    }
}
