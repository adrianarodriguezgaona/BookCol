using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class HotelController : Controller
    {
        private BookingContext bookingContext;

        public HotelController(BookingContext context)
        {
            bookingContext = context;
        }

        public IActionResult HotelDiv()
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

        public IActionResult HotelByCity(HotelFilterHotelVM vm)
        {
       var templist = Enumerable.Empty<Hotel>().AsQueryable();


            var filteredHotels = bookingContext.Hotels.Where(h => h.CityId == vm.CityId);

            

            if (vm.StarsChecked[0] == true && filteredHotels.Where(h => h.Stars == 2) != null)

            {
               templist = templist.Concat(filteredHotels.Where(h => h.Stars == 2));


            }


            if (vm.StarsChecked[1] == true && filteredHotels.Where(h => h.Stars == 3) != null)

            {
                templist = templist.Concat(filteredHotels.Where(h => h.Stars == 3));
            }

            if (vm.StarsChecked[2] == true && filteredHotels.Where(h => h.Stars == 4) != null)

            {
            templist = templist.Concat(filteredHotels.Where(h => h.Stars == 4));
            }

                    if (vm.StarsChecked[3] == true && filteredHotels.Where(h => h.Stars == 5) != null)

                    {
                      templist =   templist.Concat(filteredHotels.Where(h => h.Stars == 5));
                    }

            var finallist = templist.ToList();

                vm.Cities = bookingContext.Cities
                                .OrderBy(c => c.Name)
                                .ToList();

                if (finallist.Count == 0)

                { vm.Hotels = filteredHotels.ToList(); }

                else
                {
                    vm.Hotels = templist.ToList();
                }
            
            return View(vm);
        }
        public IActionResult HotelDetails(long id)
        {
            var vm = new HotelHotelDetailsVm();

            vm.Hotels = bookingContext.Hotels
                        .Where(h => h.Id == id)
                        .ToList();

            vm.Rooms = bookingContext.Rooms
                     .Include(rt => rt.Roomtype)
                     .Where(r => r.HotelId == id)
                     .ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult HotelByCityFilter(HotelFilterHotelVM vm)

        {
            




            return RedirectToAction("HotelByCity", vm);
        }

    }

}
    
