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

        public IActionResult AddHotel()

        { 
            return View();
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
            var vm = new AdminIndexVM();

            vm.CityList = bookingContext.Cities.OrderBy(c => c.Name).ToList();
            return View(vm);

        }
        string uniqueFileName;

        private string SaveHotelImage(IFormFile file)
        {
            uniqueFileName = file.FileName;
            string savePath = Path.Combine(_env.WebRootPath, "images", "hotels", uniqueFileName);

            using (var newfileStream = new FileStream(savePath, FileMode.Create)) { file.CopyTo(newfileStream); }
            return uniqueFileName;
        }


        [HttpPost]

        public ActionResult HotelNew(AdminIndexVM newHotel)

        {
            SaveHotelImage(newHotel.ImageToUpload);
            newHotel.Photo = uniqueFileName;

            bookingContext.Hotels.Add(newHotel);
            bookingContext.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult HotelToFill(long id)

        {
            var vm = new AdminIndexVM();

            vm.Hotel = bookingContext.Hotels.Find(id);
            vm.Roomtypes = bookingContext.Roomtypes.OrderBy(r => r.Id).ToList();
            vm.Rooms = bookingContext.Rooms.Where(h => h.HotelId == id).ToList();

            return View(vm);

        }


        public IActionResult AddRooms(string hotelId)


        {
            var vm = new EditRoomsVM();
            vm.HotelId = Convert.ToInt64(hotelId);
            vm.Roomtypes = bookingContext.Roomtypes.OrderBy(t => t.Type).ToList();

            return View(vm);
        }



        [HttpPost]

        public IActionResult AddRooms(EditRoomsVM room)

        {

            var aantalkamers = bookingContext.Rooms.Count(r => r.HotelId == room.HotelId);

            var hotel = bookingContext.Hotels.Find(room.HotelId);
            hotel.NmbrOfRooms = aantalkamers + 1;

            bookingContext.Rooms.Add(room);
            bookingContext.Update(hotel);



            bookingContext.SaveChanges();

            return RedirectToAction("HotelToFill", new { id = room.HotelId });

        }


        public IActionResult EditRoom(long id)
        {
            var vm = new EditRoomsVM();

            vm.Room = bookingContext.Rooms.Find(id);
            vm.Roomtypes = bookingContext.Roomtypes.OrderBy(r => r.Type).ToList();

            return View(vm);

        }


        [HttpPost]

        public IActionResult EditRoom(EditRoomsVM editedRoom)

        {

            Room room = editedRoom.Room;

            bookingContext.Rooms.Update(room);
            bookingContext.SaveChanges();

            return RedirectToAction("HotelToFill", new { id = room.HotelId });
        }


       

        [HttpGet]
        public IActionResult DeleteR(long id)

        {

            Room roomToDelete = bookingContext.Rooms.Find(id);
            Hotel hotel = bookingContext.Hotels.Find(roomToDelete.HotelId);
            hotel.NmbrOfRooms--;


            bookingContext.Update(hotel);
            bookingContext.Remove(roomToDelete);
            
            bookingContext.SaveChanges();

            return RedirectToAction("HotelToFill", new { id = roomToDelete.HotelId });
        }
    }
}