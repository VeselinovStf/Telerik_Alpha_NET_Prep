using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieSystem.Data;
using MovieSystem.Models;
using MovieSystem.MovieServices.Abstract;
using MovieSystem.MovieServices.Exceptions;
using MovieSystem.Web.ViewModels;
using ValidatorGuard.CustomExceptions;

namespace MovieSystem.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;
        private readonly ILogger<MovieController> logger;

        public MovieController(IMovieService movieService, ILogger<MovieController> logger)
        {
            this.movieService = movieService;
            this.logger = logger;
        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {
            var serviceCall = await this.movieService.AllFiltered(null, null);

            var model = Mapper.Map<IList<MovieViewModel>>(serviceCall);

            return View(model);
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {           
            try
            {
                var serviceCall = await this.movieService.FirstOrDefaultAsync(id);

                var model = Mapper.Map<MovieViewModel>(serviceCall);

                return View(model);
            }
            catch (LessThenZeroValueException ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
           catch    (ObjectNullException ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
           
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,IsDeleted")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                await this.movieService.Add(movie.Title, movie.ReleaseDate, movie.Price, movie.Genre);

                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var serviceCall = await this.movieService.FirstOrDefaultAsync(id);

            var movie = Mapper.Map<MovieViewModel>(serviceCall);

            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,IsDeleted")] Movie movie)
        {          
            if (ModelState.IsValid)
            {
                try
                {
                    await this.movieService.Update(movie);
                    this.logger.LogInformation("Succesfull Edit");
                }
                catch (EntitiNotFoundException ex)
                {
                    this.logger.LogError(ex.Message);
                    return NotFound();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.logger.LogError(ex.Message);
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var serviceCall = await this.movieService.FirstOrDefaultAsync(id);

            var movie = Mapper.Map<MovieViewModel>(serviceCall);

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.movieService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

      
    }
}
