using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using RazorPagesMovie.MovieServices.Abstract;

namespace RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly IMovieService movieService;

        public CreateModel(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await this.movieService.Add( Movie.Title, Movie.ReleaseDate, Movie.Price, Movie.Genre);

            return RedirectToPage("./Index");
        }
    }
}