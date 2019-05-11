using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Models;

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

       
    }
}
