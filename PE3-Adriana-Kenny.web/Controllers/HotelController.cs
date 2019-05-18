using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class HotelController : Controller
    {
        private BookingContext bookingContext;

        public HotelController (BookingContext context)
        {
            bookingContext = context;
        }

        public IActionResult HotelDiv ( )
        {
            var vm = new HotelFilterHotelVM();

            vm.Hotels = bookingContext.Hotels
                       .Include(c => c.City)
                       .ToList();

            vm.Steden = bookingContext.Cities
                     .OrderBy(c => c.Name)
                     .ToList();

            return View(vm);
        }

        public IActionResult HotelByCity(long id)
        {
            var vm = new HotelFilterHotelVM();

            vm.Hotels = bookingContext.Hotels
                       .Include(c => c.City)
                       .Where(h => h.CityId == id)
                       .ToList();

            vm.Steden = bookingContext.Cities
                        .OrderBy(c => c.Name)
                        .ToList();
                        
            return View(vm);
        }

        public IActionResult HotelDetails(long id)
        {
            var vm = new HotelHotelDetailsVm();

            vm.Hotels = bookingContext.Hotels
                        .Where(h => h.Id == id)
                        .ToList();

            vm.Rooms = bookingContext.Rooms
                     .Include (rt => rt.Roomtype)   
                     .Where(r => r.HotelId == id)
                     .ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult HotelByCity()

        {
            var stad = Request.Form["Stad"][0];
            Convert.ToInt64(stad);
            return RedirectToAction("HotelByCity", new { id = stad });
        }


    }
}