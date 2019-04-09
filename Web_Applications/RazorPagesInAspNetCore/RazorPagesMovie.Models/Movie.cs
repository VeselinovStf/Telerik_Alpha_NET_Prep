﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Gender { get; set; }
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
