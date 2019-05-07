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
        public long CustomerId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }        
        public int ZipCode { get; set; }
        public string Community { get; set; }
        public string Country { get; set; }      
        public string  Email { get; set; }

   }
}
