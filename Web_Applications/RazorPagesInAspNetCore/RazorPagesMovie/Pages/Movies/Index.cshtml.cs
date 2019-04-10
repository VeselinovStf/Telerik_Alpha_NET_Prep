using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.MovieServices.Abstract;
using RazorPagesMovie.Pages.Movies.ViewModels;
using RazorPagesMovie.Utilities.Abstract;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel, ISearchBarProps
    {
        private readonly IMovieService movieService;
        
        public IndexModel(IMovieService movieService)
        {
            this.movieService = movieService;
            
        }

        public IList<MovieViewModel> Movie { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get ; set ; }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> Genres { get ; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get ; set ; }

        public async Task OnGetAsync()
        {
            var serviceMoviesDto = await this.movieService.GetAllMoviesFiltered(SearchString,MovieGenre);
            
            Movie = Mapper.Map<IList<MovieViewModel>>(serviceMoviesDto);          

            Genres = new List<SelectListItem>(
                Movie
                .Select(spslr => new SelectListItem() { Text = spslr.Genre }));
                  
                
        }
    }
}
