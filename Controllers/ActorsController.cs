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
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;
        public ActorsController(IActorsService actorsService)
        {
             _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _actorsService.GetAllAsync());
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get: Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorsService.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _actorsService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
