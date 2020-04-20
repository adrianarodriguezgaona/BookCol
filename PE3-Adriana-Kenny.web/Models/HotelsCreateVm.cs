using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Models
{
    public class HotelsCreateVm
    {
        [Display(Name = "Stad")]
        [Required(ErrorMessage = "kies een stad a.u.b")]
        public long? CityId { get; set; }

        [Display (Name = "Naam")]
        [Required(ErrorMessage = "Geef de naam a.u.b")]
        [MaxLength(60)]
        public string Name { get; set; }

        [Display(Name = "Aantal sterren")]
        [Required(ErrorMessage = "Geef het aantal sterren a.u.b")]
        [Range(1, 5, ErrorMessage = "{0} moet tussen{1} en {2} zijn")]
        public int Stars { get; set; }


        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Geef het adres a.u.b")]
        [MaxLength(120)]
        public string Address { get; set; }

        [Display(Name = "Aantal kamers")]
        [Required(ErrorMessage = "Geef het aantal kamers a.u.b")]
        [Range(1, 15, ErrorMessage = "{0} moet tussen{1} en {2} zijn")]
        public int NmbrOfRooms { get; set; }


        [Display(Name = "Foto")]       
        [MaxLength(250)]
        public string Photo { get; set; }


        [Display(Name = "Beschrijving")]
        [Required(ErrorMessage = "Geef een beschrijving a.u.b")]
        [MaxLength(500)]
        public string Description { get; set; }

        [Display(Name = "Faciliteiten")]
        [Required(ErrorMessage = "Geef de faciliteiten a.u.b")]
        [MaxLength(500)]
        public string Facilities { get; set; }

        public City City { get; set; }

        public List<Room> Rooms { get; set; }

        public IEnumerable<City> AvailableCities { get; set; }

        [Required(ErrorMessage = "Voeg een foto toe a.u.b.")]
        public IFormFile UploadedImage { get; set; }
    }
}
