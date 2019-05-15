using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Components
{
    [ViewComponent(Name = "NavFooter")]
    public class NavFooterComponent : ViewComponent
    {
        private BookingContext bookingContext;

        public NavFooterComponent(BookingContext context)
        {
            bookingContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vm = new HomeIndexVM();

            vm.Cities = bookingContext.Cities.OrderBy(c => c.Name).ToList();

            return View(vm);
        }
    }
}
