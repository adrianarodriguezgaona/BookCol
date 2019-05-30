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
using System.Text;
using PE3_Adriana_Kenny.web.Constants;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

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


            if (ModelState.IsValid)

            {

                MD5 hash = MD5.Create();
                var userPassword = System.Text.Encoding.ASCII.GetBytes(client.Password);
                var hashBytes = hash.ComputeHash(userPassword);

                StringBuilder hashString = new StringBuilder();


                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashString.Append(hashBytes[i].ToString("x2"));
                }

                client.Password = hashString.ToString();
                client.RepeatPassword = client.Password;

                bookingContext.Clients.Add(client);
                bookingContext.SaveChanges();



                return RedirectToAction("Index");
            }

            else return View(client);

        }


        public IActionResult LoginForm()

        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoggingIn(HomeLoginFormVM login)

        {

            if (ModelState.IsValid)

            {
                MD5 hash = MD5.Create();
                var userPassword = System.Text.Encoding.ASCII.GetBytes(login.Password);
                var hashBytes = hash.ComputeHash(userPassword);

                StringBuilder hashString = new StringBuilder();


                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashString.Append(hashBytes[i].ToString("x2"));
                }

                login.Password = hashString.ToString();

                //----------------------------------

                var existingUser = bookingContext.Clients.FirstOrDefault(c => c.Email == login.Email && c.Password == login.Password);
                UserState userState = new UserState();

                if (existingUser == null)
                { return RedirectToAction("LoginForm", "Home"); }


                else if (existingUser.IsAdmin == true)

                {


                    userState.IsLoggedIn = true;
                    userState.IsAdmin = true;
                    HttpContext.Session.SetString(Constants.Constants.Statekey, JsonConvert.SerializeObject(userState));



                    return RedirectToAction("LogInSuccess", "Home");
                }

                else
                {
                    userState.IsLoggedIn = true;
                    userState.IsAdmin = false;

                    HttpContext.Session.SetString(Constants.Constants.Statekey, JsonConvert.SerializeObject(userState));


                    return RedirectToAction("LogInSucces", "Home");
                }
            }
            return RedirectToAction("LogInFail", "Home");

        }

        public IActionResult LogInSuccess()


        {
            return View();
        }

        public IActionResult LogInFail()


        {
            return View();
        }
    }
}
