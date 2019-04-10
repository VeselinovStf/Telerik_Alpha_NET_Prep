﻿using MovieSystem.Models;
using MovieSystem.MovieServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.MovieServices.Abstract
{
    public interface IMovieService
    {
        Task<IList<MovieDto>> GetAllMoviesFiltered(string searchString, string movieGenre);

        Task Add(string title, DateTime releaseDate, decimal price, string Genre);
        Task<MovieDto> GetById(int? id);

        Task RemoveMovie(int? id);
        Task Edit(Movie movie);
    }
}
