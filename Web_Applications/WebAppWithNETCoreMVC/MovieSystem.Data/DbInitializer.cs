using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data
{
    public class DbInitializer
    {
        public static async Task SeedDataAsync(ILoggerFactory loggerFactory
            , MovieSystemDbContext context
            , int? retry = 0)
        {
            var retryForAveilability = retry.Value;
            var log = loggerFactory.CreateLogger<DbInitializer>();

            try
            {
                context.Database.Migrate();

                if (!context.Movies.Any())
                {
                    await context.Movies.AddRangeAsync(GetMovies());
                    log.LogInformation("Movies succesfully added to Db.");

                    await context.SaveChangesAsync();


                }
            }
            catch (Exception ex)
            {
                if (retryForAveilability < 10)
                {
                    retryForAveilability++;
                    log.LogError(ex.Message);
                    await SeedDataAsync(loggerFactory, context, retry);
                }

            }

        }

        static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                 new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
            };

        }
    }
}
