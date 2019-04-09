using AutoMapper;
using RazorPagesMovie.Models;
using RazorPagesMovie.MovieServices.DTOs;
using RazorPagesMovie.Pages.Movies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<List<MovieDto>, List<MovieViewModel>>();
            CreateMap<MovieDto, MovieViewModel>();
            CreateMap<MovieDto, Movie>();
              
        }
    }
}
