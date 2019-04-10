using System;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
    public class Movie
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
