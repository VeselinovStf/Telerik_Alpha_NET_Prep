using MovieSystem.Models;
using MovieSystem.MovieServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.MovieServices.Abstract
{
    public interface IMovieService
    {
        Task<MoviesListDto> All(string sortOrder, string searchString, int moviePage = 1);

        Task Add(string title, DateTime releaseDate, decimal price, string Genre);
        Task<MovieDto> FirstOrDefaultAsync(int? id);

        Task Remove(int? id);
        Task Update(Movie movie);
    }
}
