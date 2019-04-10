using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Web.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-ZA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
