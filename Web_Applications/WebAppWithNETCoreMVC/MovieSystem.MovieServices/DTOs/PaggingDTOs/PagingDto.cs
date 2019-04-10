using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSystem.MovieServices.DTOs.PaggingDTOs
{
    public class PagingDto
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
