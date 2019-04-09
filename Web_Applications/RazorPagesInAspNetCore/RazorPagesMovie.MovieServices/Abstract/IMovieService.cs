using RazorPagesMovie.Models;
using RazorPagesMovie.MovieServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesMovie.MovieServices.Abstract
{
    public interface IMovieService
    {
        Task<IList<MovieDto>> GetAll();
        Task Add(string title, DateTime releaseDate, decimal price, string gender);
        Task<MovieDto> GetById(int? id);

        Task RemoveMovie(int? id);
        Task Edit(Movie movie);
    }
}
