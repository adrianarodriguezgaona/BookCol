using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;
using PE3_Adriana_Kenny.web.Models;

namespace PE3_Adriana_Kenny.web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IRepository<Hotel, long> _hRepository;
        private readonly IRepository<City, long> _cRepository;
        private readonly IHostingEnvironment _env;

        public HotelsController
            (
             IRepository<Hotel, long> hRepository,
             IRepository<City, long> cRepository,
             IHostingEnvironment env
            )
        {
            _hRepository = hRepository;
            _cRepository = cRepository;
            _env = env;
        }

        // GET: Hotels
        public async Task<IActionResult> Index()
        {
            var vm = new HotelsIndexVM
            {
                Hotels = await _hRepository.GetAll()
                       .Include(h => h.City)
                       .OrderBy(e => e.Name).ToListAsync()
            };
            return View(vm);
        }

        // GET: Hotels/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _hRepository.GetAll()

                .Include(h => h.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // GET: Hotels/Create
        public IActionResult Create()
        {
            var vm = new HotelsCreateVm
            {              
                NmbrOfRooms = 0,
                Stars = 0,
            };
            vm.AvailableCities = _cRepository.GetAll().OrderBy(c => c.Name);

            return View(vm);
        }

        // POST: Hotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelsCreateVm createVm)
        {
            if (ModelState.IsValid)
            {
                City city = await _cRepository.GetByIdAsync(createVm.CityId.Value);
                
                if (city != null)
                {

                
                Hotel createdHotel = new Hotel
                {
                    Name = createVm.Name,
                    Description = createVm.Description,
                    Stars = createVm.Stars,
                    Address = createVm.Address,
                    CityId = createVm.CityId,
                    NmbrOfRooms = createVm.NmbrOfRooms,
                    Photo = createVm.Photo,
                };

                    createdHotel.Photo = await SaveHotelImage(createVm.UploadedImage);


                await _hRepository.AddAsync(createdHotel);
                
                return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(nameof(createVm.CityId), "Dit stad bestaat niet");

                }
            }
            createVm.AvailableCities = _cRepository.GetAll().OrderBy(c => c.Name);

            return View(createVm);
        }

        // GET: Hotels/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _hRepository.GetAll()
                        .Include(h => h.City)
                        .SingleOrDefaultAsync( h => h.Id == id);   

            if (hotel == null)
            {
                return NotFound();
            }
            var vm = new HotelsEditVM
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address,
                Description = hotel.Description,
                NmbrOfRooms = hotel.NmbrOfRooms,
                Stars = hotel.Stars,
                Facilities = hotel.Facilities,
                Photo = hotel.Photo,
                CityId = hotel.City.Id,
                AvailableCities = _cRepository.GetAll().OrderBy(c => c.Name)         
            };
            return View(vm);
        }

        // POST: Hotels/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, HotelsEditVM editVm)
        {
            if (id != editVm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    City city = await _cRepository.GetByIdAsync(editVm.CityId.Value);

                    if (city != null)
                    {

                    Hotel updatedHotel = new Hotel
                    {
                        Id = editVm.Id,
                        Name = editVm.Name,
                        Address = editVm.Address,
                        Description = editVm.Description,
                        Facilities = editVm.Facilities,
                        Stars = editVm.Stars,
                        NmbrOfRooms = editVm.NmbrOfRooms,
                        CityId = editVm.CityId,
                        
                    };

                    if (editVm.UploadedImage != null)
                        {
                            DeleteHotelImage(updatedHotel);
                            updatedHotel.Photo = await SaveHotelImage(editVm.UploadedImage);
                        }

                    await _hRepository.UpdateAsync(updatedHotel);

                    }
                    else
                    {
                        ModelState.AddModelError(nameof(editVm.CityId), "Deze stad bestaat niet");
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(editVm.Id))
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

            editVm.AvailableCities = _cRepository.GetAll().OrderBy(c => c.Name);
            return View(editVm);
        }

        // GET: Hotels/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _hRepository.GetAll()
                .Include(h => h.City)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var hotel = await _hRepository.GetByIdAsync(id);

            DeleteHotelImage(hotel);

            await _hRepository.DeleteAsync(hotel);
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(long id)
        {
            return _hRepository.GetAll().Any(e => e.Id == id);
        }

        private async Task<string> SaveHotelImage (IFormFile file)
        {
            string uniqueFileName = Guid.NewGuid().ToString("N") + file.FileName;
            string savePath = Path.Combine(_env.WebRootPath, "images", "hotels", uniqueFileName);

            using (var newFileStream = new FileStream (savePath, FileMode.Create))
            {
                await file.CopyToAsync(newFileStream);
            }
            return uniqueFileName;
        }

        private void DeleteHotelImage(Hotel hotel)
        {
            if (!string.IsNullOrWhiteSpace(hotel?.Photo))
            {
                string deletePath = Path.Combine(_env.WebRootPath, "images", "hotels", hotel?.Photo);
                System.IO.File.Delete(deletePath);
            }
        }
    }
}
