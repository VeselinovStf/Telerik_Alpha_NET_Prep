using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System.Threading.Tasks;

namespace RazorPagesMovie.Tests.MovieService.Tests
{
    [TestClass]
    public class GetAll_Should
    {
        [TestMethod]
        public async Task ReturnCorrectMovies()
        {
            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>().
               UseInMemoryDatabase(databaseName: "ReturnCorrectMovies")
               .Options;

            var movieName1 = "Die Hard1";
            var movieName2 = "Die Hard2";
            var movieName3 = "Die Hard3";
            var movieName4 = "Die Hard4";
                
                
            var firstMovie = new Movie() { Id = 1, Title = movieName1 };
            var secondMovie = new Movie() { Id = 2, Title = movieName2 };
            var thirdMovie = new Movie() { Id = 3, Title = movieName3 };
            var fourtMovie = new Movie() { Id = 4, Title = movieName4 };

            using (var context = new RazorPagesMovieDbContext(options))
            {
                await context.Movies.AddRangeAsync(firstMovie, secondMovie, thirdMovie, fourtMovie);
                await context.SaveChangesAsync();

                var movieService = new MovieServices.MovieService(context);

                var resultDto = await movieService.GetAllMoviesFiltered(null,null);

                Assert.IsTrue(resultDto.Count == 4);

                Assert.AreEqual(1, resultDto[0].Id);
                Assert.AreEqual(2, resultDto[1].Id);
                Assert.AreEqual(3, resultDto[2].Id);
                Assert.AreEqual(4, resultDto[3].Id);

                Assert.AreEqual(movieName1, resultDto[0].Title);
                Assert.AreEqual(movieName2, resultDto[1].Title);
                Assert.AreEqual(movieName3, resultDto[2].Title);
                Assert.AreEqual(movieName4, resultDto[3].Title);
            }


        }
    }
}
