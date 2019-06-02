using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class ClientsController : Controller
    {
        private readonly BookingContext bookingContext;

        public ClientsController(BookingContext context)
        {
            bookingContext = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            string sessionUser = HttpContext.Session.GetString(Constants.Constants.Statekey);
            if (sessionUser == null)
            {
                return RedirectToAction("LoginForm", "Home");
            }

            var userState = JsonConvert.DeserializeObject<UserState>(sessionUser);

            if (userState.IsLoggedIn && userState.IsAdmin)
            {
                var vm = new ClientsIndexVM
                {
                    Clients = await bookingContext.Clients                        
                        .OrderBy(c => c.Id)
                        .ToListAsync()
                };

                return View(vm);
            }

            return RedirectToAction("LoginForm", "Home");

        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            string sessionUser = HttpContext.Session.GetString(Constants.Constants.Statekey);
            if (sessionUser == null)
            {
                return RedirectToAction("LoginForm", "Home");
            }

            var userState = JsonConvert.DeserializeObject<UserState>(sessionUser);

            if (userState.IsLoggedIn && userState.IsAdmin)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var client = await bookingContext.Clients
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (client == null)
                {
                    return NotFound();
                }

                return View(client);
            }
            return RedirectToAction("LoginForm", "Home");
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            string sessionUser = HttpContext.Session.GetString(Constants.Constants.Statekey);
            if (sessionUser == null)
            {
                return RedirectToAction("LoginForm", "Home");
            }

            var userState = JsonConvert.DeserializeObject<UserState>(sessionUser);

            if (userState.IsLoggedIn && userState.IsAdmin)
            {

                if (id == null)
                {
                return NotFound();
                }

               var client = await bookingContext.Clients.FindAsync(id);
               if (client == null)
               {
                return NotFound();
               }
               return View(client);
            }
            return RedirectToAction("LoginForm", "Home");
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Client editClient)
        {
            if (id != editClient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    MD5 hash = MD5.Create();
                    var userPassword = System.Text.Encoding.ASCII.GetBytes(editClient.Password);
                    var hashBytes = hash.ComputeHash(userPassword);

                    StringBuilder hashString = new StringBuilder();


                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        hashString.Append(hashBytes[i].ToString("x2"));
                    }

                    editClient.Password = hashString.ToString();
                    editClient.RepeatPassword = editClient.Password;

                    Client updatedClient = new Client
                    {
                        Id = editClient.Id,
                        Surname = editClient.Surname,
                        Name = editClient.Name,
                        Address = editClient.Address,
                        ZipCode = editClient.ZipCode,
                        Community = editClient.Community,
                        Country = editClient.Country,
                        Email = editClient.Email,
                        Password = editClient.Password,
                        RepeatPassword = editClient.RepeatPassword
                    };
                    bookingContext.Update(updatedClient);
                    await bookingContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(editClient.Id))
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
            return View(editClient);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {

            string sessionUser = HttpContext.Session.GetString(Constants.Constants.Statekey);
            if (sessionUser == null)
            {
                return RedirectToAction("LoginForm", "Home");
            }

            var userState = JsonConvert.DeserializeObject<UserState>(sessionUser);

            if (userState.IsLoggedIn && userState.IsAdmin)
            {
                if (id == null)
                {
                return NotFound();
                }

               var client = await bookingContext.Clients
                           .FirstOrDefaultAsync(m => m.Id == id);
               if (client == null)
               {
                return NotFound();
                }

                return View(client);
            }
            return RedirectToAction("LoginForm", "Home");
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var client = await bookingContext.Clients.FindAsync(id);
            bookingContext.Clients.Remove(client);
            await bookingContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(long id)
        {
            return bookingContext.Clients.Any(e => e.Id == id);
        }
    }
}
