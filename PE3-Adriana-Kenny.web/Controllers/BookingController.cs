using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            vm.Hotel = bookingContext.Hotels.Find(hotelId);
                        
            vm.Rooms = bookingContext.Rooms                     
                     .Where(r => r.HotelId == hotelId)
                     .ToList();
                       return View(vm);           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookingCreateVM newBookingVM)

        {
            if (ModelState.IsValid)

            {
                Booking newBooking = new Booking()
                {
                    CheckInDate = newBookingVM.CheckInDate,
                    CheckOutDate = newBookingVM.CheckOutDate,
                    ClientId = newBookingVM.ClientId,
                    RoomId = newBookingVM.RoomId,
                    NmbrOfPeople = newBookingVM.NmbrOfPeople
                };
                bookingContext.Booking.Add(newBooking);
                bookingContext.SaveChanges();

                var vm = new BookingCreatePostVM();

                vm.Client = bookingContext.Clients.SingleOrDefault(c => c.Id == newBooking.ClientId);
                          
                vm.Bookings = bookingContext.Booking
                             .Include(b => b.Room)
                             .Where(b => b.Id == newBooking.Id)
                             .ToList();

                TimeSpan? tspan = newBooking.CheckOutDate - newBooking.CheckInDate;

                ViewBag.Days = tspan?.Days;

                return View("CreateSuccesfully", vm);
            }

            else
            {
                newBookingVM.Hotel = bookingContext.Hotels.SingleOrDefault(h => h.Id == 1);
                      
                newBookingVM.Rooms = bookingContext.Rooms
                    .Where(r => r.HotelId == 1)
                    .ToList();
                return View(newBookingVM);
            }

        }
    }
}