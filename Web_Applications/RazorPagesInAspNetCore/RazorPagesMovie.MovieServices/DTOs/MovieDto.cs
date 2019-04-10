using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesMovie.MovieServices.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
     
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
