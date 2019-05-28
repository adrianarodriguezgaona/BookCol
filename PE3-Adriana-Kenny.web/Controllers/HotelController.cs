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

            vm.Cities = bookingContext.Cities
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

            vm.Cities = bookingContext.Cities
                        .OrderBy(c => c.Name)
                        .ToList();
                        
            return View(vm);
        }

        public IActionResult HotelDetails(long id)
        {
            var vm = new HotelHotelDetailsVm();

            vm.Hotel = bookingContext.Hotels.Find(id);
                       
            vm.Rooms = bookingContext.Rooms
                     .Include (rt => rt.Roomtype)   
                     .Where(r => r.HotelId == id)
                     .ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult HotelByCityFilter(string CityId)
            
        {

            var city = CityId;
           
            return RedirectToAction("HotelByCity", new { Id = city });


        }


    }
}