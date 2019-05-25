using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3_Adriana_Kenny.web.Models
{
    public class HomeLoginFormVM
    {
        [Required(ErrorMessage = "Vul je emailadres in")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Paswoord")]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Het Paswoord moet minstens 8 karakters hebben!")]
        public string Password { get; set; }
    }
}
