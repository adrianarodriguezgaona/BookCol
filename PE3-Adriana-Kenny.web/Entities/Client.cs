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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Vul een naam in")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vul een voornaam in")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Vul een adres in")]

        public string Address { get; set; }        

        [Required(ErrorMessage = "Vul een Postcode in")]
        [Range(1000,9999, ErrorMessage = "Vul een geldige postcode in")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Vul je gemeente in")]
        public string Community { get; set; }

        [Required]
        public string Country { get; set; }
        
        [Required(ErrorMessage = "Vul je emailadres in")]
        [EmailAddress]
        public string  Email { get; set; }

        [Display(Name = "Paswoord")]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Het Paswoord moet minstens 8 karakters hebben!")]
        public string Password { get; set; }

        [Display(Name = "Herhaal het paswoord")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage = " De paswoorden matchen niet")]
        public string RepeatPassword { get; set; }

        public bool IsAdmin { get; set; }

        // navigation property
        public List<Booking> Bookings { get; set; }


    }
}
