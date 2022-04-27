using Cinema_ECommerce.Data;
using Cinema_ECommerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _moviesService.GetAllAsync(n => n.Cinema));
        }

        //GET: Movies/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _moviesService.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            //Dictionary of objects derived from dictionary class and is accessible by using strings as keys, can be used in controller and view. Requires type casting
            //ViewData["Welcome"] = "Welcome to our store";

            //ViewBag is a wrapper built around viewData, no [], dynamic property, no type casting for complex data types
            //ViewBag.Description = "This is the store description";
            var movieDropdownData = await _moviesService.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownData.Actors, "Id", "FullName");
            return View();
        }
    }
}
