using MovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentSorting.Abstract
{
    public interface IPageSort
    {
        Task<IQueryable<Movie>> Sort(string order);
    }
}
