using AutoMapper;
using MovieSystem.Models;
using MovieSystem.MovieServices.DTOs;
using MovieSystem.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Web.Utilities
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
