using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class AdminController : Controller
    {


        private BookingContext bookingContext;
        private readonly IHostingEnvironment _env;

        public AdminController(BookingContext context, IHostingEnvironment env)
        {
            bookingContext = context;
            _env = env;
        }

        public IActionResult Index()

      
        {
            var vm = new AdminIndexVM();
                vm.Hotels = bookingContext.Hotels.OrderBy(h => h.Name).ToList();

                return View(vm);
        }

        [HttpPost]
        public IActionResult Index(long id)

        {

            return RedirectToAction("AdminEditRemove", new { id = id });
        }

        public IActionResult AdminEditRemove(long id)

        {
            var vm = new Hotel();

                vm = bookingContext.Hotels.Find(id);

            return View(vm);
        }


        [HttpPost]
        public IActionResult HotelEdit(Hotel hotel, string submitbutton)

        {
            if (submitbutton == "Wijzigen")
            {
                bookingContext.Update(hotel);
                bookingContext.SaveChanges();

                return Redirect("index");
            }
            else
            {
                bookingContext.Remove(hotel);
                bookingContext.SaveChanges();
                return Redirect("index");

            }
        }
        public IActionResult HotelNew()
        {
            var vm = new HotelNewVM();

            vm.CityList = bookingContext.Cities.OrderBy(c => c.Name).ToList();
            return View(vm);

        }
        string uniqueFileName;

        private string SaveHotelImage(IFormFile file)
        {
             uniqueFileName = file.FileName;
            string savePath = Path.Combine(_env.WebRootPath, "images", "hotels", uniqueFileName);

            using (var newfileStream = new FileStream(savePath, FileMode.Create)) {  file.CopyTo(newfileStream); }
            return uniqueFileName;
        }


        [HttpPost]

        public ActionResult HotelNew(HotelNewVM nieuwHotel)
            
        {
        
                SaveHotelImage(nieuwHotel.ImageToUpload);
            nieuwHotel.Photo = uniqueFileName;

            bookingContext.Hotels.Add(nieuwHotel);
            bookingContext.SaveChanges();



            return Redirect("index");
        }







        
        
        



    }
}