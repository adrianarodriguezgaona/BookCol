using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class AdminController : Controller
    {


        private BookingContext bookingContext;

        public AdminController(BookingContext context)
        {
            bookingContext = context;
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

          
            }
            else { bookingContext.Remove(hotel);
                bookingContext.SaveChanges();

               
            }
            return Redirect("index");
        }


        
        
        



    }
}