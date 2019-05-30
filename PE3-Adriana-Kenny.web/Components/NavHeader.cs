using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Components
{
    [ViewComponent(Name = "NavHeader")]
    public class NavHeaderComponent : ViewComponent
    {
        private BookingContext bookingContext;

        public NavHeaderComponent(BookingContext context)
        {
            bookingContext = context;
        }
        public IViewComponentResult Invoke()
        {
           
            return View();

        }
    }
    }

