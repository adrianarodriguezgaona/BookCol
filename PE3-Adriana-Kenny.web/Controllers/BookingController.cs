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
    public class BookingController : Controller
    {
        private BookingContext bookingContext;

        public BookingController(BookingContext context)
        {
            bookingContext = context;
        }

        public IActionResult Create(long hotelId)
        {
            var vm = new BookingCreateVM();

            vm.Hotels = bookingContext.Hotels
                        .Where(h => h.Id == hotelId)
                        .ToList();

            vm.Rooms = bookingContext.Rooms                     
                     .Where(r => r.HotelId == hotelId)
                     .ToList();

                       return View(vm);           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Booking newBooking)

        {
            if (ModelState.IsValid)

            {
                bookingContext.Booking.Add(newBooking);
                bookingContext.SaveChanges();

                var vm = new BookingCreatePostVM();

                vm.Clients = bookingContext.Clients
                           .Where(c => c.Id == newBooking.ClientId)
                           .ToList();

                vm.Booking = newBooking;
               
                TimeSpan tspan = newBooking.CheckOutDate - newBooking.CheckInDate;
                    
                ViewBag.Days = tspan.Days;

                return View("CreateSuccesfully",vm);
            }

            else return View(newBooking);


        }
    }
}