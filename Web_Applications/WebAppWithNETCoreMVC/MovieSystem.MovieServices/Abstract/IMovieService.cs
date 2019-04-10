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
        Task<IList<MovieDto>> AllFiltered(string searchString, string movieGenre);

        Task Add(string title, DateTime releaseDate, decimal price, string Genre);
        Task<MovieDto> FirstOrDefaultAsync(int? id);

        Task Remove(int? id);
        Task Update(Movie movie);
    }
}
