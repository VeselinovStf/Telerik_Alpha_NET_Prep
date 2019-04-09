using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.MovieServices.Abstract;
using RazorPagesMovie.Pages.Movies.ViewModels;
using ValidatorGuard.CustomExceptions;

namespace RazorPagesMovie.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly IMovieService movieService;
       // private readonly ILogger logger;

        public DeleteModel(IMovieService movieService)//, ILogger logger)
        {
            this.movieService = movieService;
            //this.logger = logger;
        }

        [BindProperty]
        public MovieViewModel Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                var serviceModel = await this.movieService.GetById(id);

                Movie = Mapper.Map<MovieViewModel>(serviceModel);

            }
            catch (ObjectNullException ex)
            {
                //this.logger.LogError(ex.Message);

                return NotFound();
            }
            catch (LessThenZeroValueException ex)
            {
                //this.logger.LogError(ex.Message);

                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            try
            {
                await this.movieService.RemoveMovie(id);
            }
            catch (LessThenZeroValueException ex)
            {
              // this.logger.LogError(ex.Message);

                return NotFound();
            }

            
            return RedirectToPage("./Index");
        }
    }
}
