using Cinema_ECommerce.Data;
using Cinema_ECommerce.Data.Services;
using Cinema_ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemaService;
        public CinemasController(ICinemasService cinemaService)
        {
            _cinemaService = cinemaService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _cinemaService.GetAllAsync());
        }
        //GET: Cinema/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)
        {
            if(!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinema/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _cinemaService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        //GET: Cinema/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _cinemaService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema cinema)
        {
            if(!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _cinemaService.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinema/Delete0
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _cinemaService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDetails = await _cinemaService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");

            await _cinemaService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
