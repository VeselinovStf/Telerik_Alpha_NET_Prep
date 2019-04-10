using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Utilities.Abstract
{
    public interface IMovieSearchBarProps
    {
        SelectList Genres { get; set; }

        
        string MovieGenre { get; set; }
    }
}
