using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages.Movies.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
     
        public DateTime ReleaseDate { get; set; }

        public string Gender { get; set; }
        public decimal Price { get; set; }
    }
}
