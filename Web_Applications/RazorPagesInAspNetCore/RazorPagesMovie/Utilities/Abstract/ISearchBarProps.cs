using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Utilities.Abstract
{
    public interface ISearchBarProps
    {
        
         string SearchString { get; set; }

    }
}
