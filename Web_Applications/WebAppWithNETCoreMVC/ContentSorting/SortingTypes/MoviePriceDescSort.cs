using ContentSorting.Abstract;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Data;
using MovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentSorting.SortingTypes
{
    public class MoviePriceDescSort : ISortAction<Movie>
    {
        //public readonly CONNECTION TO GET FROM 
        private readonly MovieSystemDbContext context;

        public MoviePriceDescSort(MovieSystemDbContext context)
        {
            this.context = context;
        }

        //Sorting/Ordering action
        public async Task<IQueryable<Movie>> Order()
        {
            var call = await this.context.Movies.OrderByDescending(e => e.Price).ToListAsync();

            return call.AsQueryable();
        }

    }
}
