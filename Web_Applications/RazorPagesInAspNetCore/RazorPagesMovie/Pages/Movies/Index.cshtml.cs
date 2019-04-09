using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.MovieServices.Abstract;
using RazorPagesMovie.Pages.Movies.ViewModels;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IMovieService movieService;
        

        public IndexModel(IMovieService movieService)
        {
            this.movieService = movieService;        
        }

        public IList<MovieViewModel> Movie { get;set; }

        public async Task OnGetAsync()
        {
            var serviceDto = await this.movieService.GetAll();

            Movie = Mapper.Map<IList<MovieViewModel>>(serviceDto);
        }
    }
}
