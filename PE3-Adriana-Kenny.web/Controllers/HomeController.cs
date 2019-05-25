using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;
using System.Security.Cryptography;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class HomeController : Controller
    {

        private BookingContext bookingContext;

        public HomeController(BookingContext context)
        {
            bookingContext = context;
        }

        public IActionResult Index()
        {
            var vm = new HomeIndexVM();

            vm.Cities = bookingContext.Cities.OrderBy(c => c.Name).ToList();

            return View(vm);
        }


        public IActionResult RegisterForm()

        {
            var vm = new Client();
            return View(vm);


        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult RegisterForm(Client client)
        {
            MD5 hash = MD5.Create();
           var passToBytes = System.Text.Encoding.ASCII.GetBytes(client.Password);
           var hashBytes = hash.ComputeHash(passToBytes);

            if (ModelState.IsValid)

            {


                bookingContext.Clients.Add(client);
                bookingContext.SaveChanges();



                return RedirectToAction("Index");
            }

            else return View(client);

        }


    }
}
