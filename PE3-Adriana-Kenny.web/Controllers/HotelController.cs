﻿using System;
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

        public IActionResult HotelByCity (long id)

        {
            var vm = new HotelFilterHotelVM();

            vm.Hotels = bookingContext.Hotels
                .Include(c => c.City)
                .Where(h => h.CityId == id).ToList();
            vm.CityId = id;


            vm.Cities = bookingContext.Cities.OrderBy(c => c.Name).ToList();

            return View(vm);

        }



        public IActionResult HotelFilteredCityStar(HotelFilterHotelVM vm)
        {
       //var templist = Enumerable.Empty<Hotel>().AsQueryable();

            var hotelsBycity = bookingContext.Hotels.Where(h => h.CityId == vm.CityId ).ToList();

            var hotelsByStar = bookingContext.Hotels.Where(h => h.Stars == vm.AmountStars).ToList();

            if (hotelsBycity.Count != 0 && hotelsByStar.Count == 0)
            {
                vm.Hotels = bookingContext.Hotels.Where(h => h.CityId == vm.CityId).ToList();
            }

            if (hotelsBycity.Count != 0 && hotelsByStar.Count != 0)

            {
                vm.Hotels = bookingContext.Hotels.Where(h => h.CityId == vm.CityId &&  h.Stars == vm.AmountStars).ToList();
            }

            if (hotelsBycity.Count == 0 && hotelsByStar.Count != 0)

            {
                vm.Hotels = bookingContext.Hotels.Where(h => h.Stars == vm.AmountStars).ToList();
            }

            //if (vm.StarsChecked[0] == true && filteredHotels.Where(h => h.Stars == 2) != null)

            //{
            //   templist = templist.Concat(filteredHotels.Where(h => h.Stars == 2));

            //}

            //if (vm.StarsChecked[1] == true && filteredHotels.Where(h => h.Stars == 3) != null)

            //{
            //    templist = templist.Concat(filteredHotels.Where(h => h.Stars == 3));
            //}

            //if (vm.StarsChecked[2] == true && filteredHotels.Where(h => h.Stars == 4) != null)

            //{
            //templist = templist.Concat(filteredHotels.Where(h => h.Stars == 4));
            //}

            //        if (vm.StarsChecked[3] == true && filteredHotels.Where(h => h.Stars == 5) != null)

            //        {
            //          templist =   templist.Concat(filteredHotels.Where(h => h.Stars == 5));
            //        }

            //var finallist = templist.ToList();

            vm.Cities = bookingContext.Cities
                        //.Where (c => c.Id == vm.CityId)
                        .OrderBy(c => c.Name)
                        .ToList();

            //if (finallist.Count == 0)

            //{ vm.Hotels = filteredHotels.ToList(); }

            //else
            //{
            //    vm.Hotels = templist.ToList();
            //}

            return View("HotelByCity", vm);
        }
        public IActionResult HotelDetails(long id)
        {
            var vm = new HotelHotelDetailsVm();

            vm.Hotel = bookingContext.Hotels.Find(id);
                       
            vm.Rooms = bookingContext.Rooms
                     .Include(rt => rt.Roomtype)
                     .Where(r => r.HotelId == id)
                     .ToList();
            return View(vm);
        }

        [HttpPost]
        public IActionResult HotelByCityFilter(HotelFilterHotelVM vm)

        {
            
            return RedirectToAction("HotelFilteredCityStar", vm);
        }

    }

}
    
