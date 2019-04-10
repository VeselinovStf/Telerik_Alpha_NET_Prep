using MovieSystem.Data.Infrastructure.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Web.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<MovieViewModel> Movies { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
