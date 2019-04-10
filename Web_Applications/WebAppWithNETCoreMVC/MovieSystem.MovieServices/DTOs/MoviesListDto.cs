using MovieSystem.MovieServices.DTOs.PaggingDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSystem.MovieServices.DTOs
{
    public class MoviesListDto
    {
        public IEnumerable<MovieDto> Movies { get; set; }
        public PagingDto PagingInfo { get; set; }
    }
}
