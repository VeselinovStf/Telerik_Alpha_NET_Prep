using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.MovieServices.Abstract;
using RazorPagesMovie.Pages.Movies.ViewModels;
using ValidatorGuard.CustomExceptions;

namespace RazorPagesMovie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieService movieService;
        

        public DetailsModel(IMovieService movieService)
        {
            this.movieService = movieService;
            
        }

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
               

                return NotFound();
            }
            catch (LessThenZeroValueException ex)
            {
               

                return NotFound();
            }

            return Page();
        }
    }
}
