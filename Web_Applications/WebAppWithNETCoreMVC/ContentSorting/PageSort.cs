using ContentSorting.Abstract;
using ContentSorting.SortingTypes;
using MovieSystem.Data;
using MovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversitySystem.Models.Entities;

namespace ContentSorting
{
    public class PageSort : IPageSort
    {
        // Set for every Sortable entity
        public Dictionary<PageSortRule, ISortAction<Movie>> Options =
            new Dictionary<PageSortRule, ISortAction<Movie>>();

        public PageSort(MovieSystemDbContext context)
        {
            this.Options.Add(PageSortRule.Genre, new MovieGenreDescSort(context));
            this.Options.Add(PageSortRule.Title, new MovieTitleDescSort(context));
            this.Options.Add(PageSortRule.Price, new MoviePriceDescSort(context));
            this.Options.Add(PageSortRule.ReleaseDate, new MovieReleseDateDescSort(context));
        }
       
        public async Task<IQueryable<Student>> Sort<IQueryable<Movie>>(string order)
        {
            var orderKey = (PageSortRule)Enum.Parse(typeof(PageSortRule), order, true);

            var ordered = await Options[orderKey].Order();

            return ordered.AsQueryable();
        }
    }
}
