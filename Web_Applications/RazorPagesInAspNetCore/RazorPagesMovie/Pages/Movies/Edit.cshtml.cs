using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using RazorPagesMovie.MovieServices;
using RazorPagesMovie.MovieServices.Abstract;
using ValidatorGuard.CustomExceptions;

namespace RazorPagesMovie.Pages.Movies
{
    //TOODO: Fix AutoMapper error
    public class EditModel : PageModel
    {
        private readonly IMovieService movieService;
       // private readonly ILogger logger;

        public EditModel(IMovieService movieService) //ILogger logger)
        {
            this.movieService = movieService;
            //this.logger = logger;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                var serviceModel = await this.movieService.GetById(id);

                Movie = Mapper.Map<Movie>(serviceModel);

            }
            catch (ObjectNullException ex)
            {
                //this.logger.LogError(ex.Message);

                return NotFound();
            }
            catch (LessThenZeroValueException ex)
            {
               // this.logger.LogError(ex.Message);

                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await movieService.Edit(Movie);
            }
            catch (EntitiNotFoundException ex)
            {

                return NotFound();
            }
            
          
            return RedirectToPage("./Index");
        }

      
    }
}
