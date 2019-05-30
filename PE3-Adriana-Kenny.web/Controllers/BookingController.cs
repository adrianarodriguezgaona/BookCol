using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class BookingController : Controller
    {
        private BookingContext bookingContext;

        public BookingController(BookingContext context)
        {
            bookingContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new BookingIndexVM
            {
                Bookings = await bookingContext.Booking
                          .Include(c => c.Client)
                          .OrderBy(b => b.Id)
                          .ToListAsync()
            };

            return View(vm);


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

        public async Task<IActionResult> Edit (long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var booking = await bookingContext.Booking.SingleOrDefaultAsync(b => b.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            var vm = new BookingEditVM
            {
                Id = booking.Id,
                ClientId = booking.ClientId,
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                RoomId = booking.RoomId,
                NmbrOfPeople = booking.NmbrOfPeople
            };
            
            vm.Rooms = await bookingContext.Rooms
                     .OrderBy(r => r.Id).ToListAsync();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit (long id, BookingEditVM editVm)
        {
            if(id != editVm.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Booking updatedBooking = new Booking
                    {
                        CheckInDate = editVm.CheckInDate,
                        CheckOutDate = editVm.CheckOutDate,
                        NmbrOfPeople = editVm.NmbrOfPeople,
                        RoomId = editVm.RoomId,
                        ClientId = editVm.ClientId,

                    };
                    bookingContext.Update(updatedBooking);
                    await bookingContext.SaveChangesAsync();
                   
                    editVm.Rooms = await bookingContext.Rooms
                    .OrderBy(r => r.Id).ToListAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(editVm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editVm);
        }

        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await bookingContext.Booking
                 .Include(b => b.Client)
                 .Include(b => b.Room)
                 .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null)
            {
                return NotFound();
            }


            return View(booking);
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await bookingContext.Booking
                .Include(b => b.Client)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var booking = await bookingContext.Booking.FindAsync(id);
            bookingContext.Booking.Remove(booking);
            await bookingContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(long id)
        {
            return bookingContext.Booking.Any(e => e.Id == id);
        }
    }
}