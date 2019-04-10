using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System.Threading.Tasks;

namespace RazorPagesMovie.Tests.MovieService.Tests
{
    [TestClass]
    public class GetAllMoviesFiltered_Should
    {
        [TestMethod]
        public async Task ReturnCorrectMovies_WithNoFiltering()
        {
            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>().
               UseInMemoryDatabase(databaseName: "ReturnCorrectMovies_WithNoFiltering")
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

        [TestMethod]
        public async Task ReturnCorrectMovie_WithGenreFilter()
        {
            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>().
              UseInMemoryDatabase(databaseName: "ReturnCorrectMovie_WithGenreFilter")
              .Options;

            var movieName1Action = "Die Hard1";
            var movieName2Action = "Die Hard2";
            var movieName3Comedy = "So so funny1";
            var movieName4Comedy = "So so fynny2";

            var genreAction = "Action";
            var genreComedy = "Comedy";


            var firstMovieAction = new Movie() { Id = 1, Title = movieName1Action, Genre = genreAction };
            var secondMovieAction = new Movie() { Id = 2, Title = movieName2Action , Genre = genreAction };
            var thirdMovieComedy = new Movie() { Id = 3, Title = movieName3Comedy, Genre = genreComedy };
            var fourtMovieComedy = new Movie() { Id = 4, Title = movieName4Comedy, Genre = genreComedy };

            using (var context = new RazorPagesMovieDbContext(options))
            {
                await context.Movies.AddRangeAsync(firstMovieAction, secondMovieAction, thirdMovieComedy, fourtMovieComedy);
                await context.SaveChangesAsync();

                var movieService = new MovieServices.MovieService(context);

                var resultDto = await movieService.GetAllMoviesFiltered(null, genreAction);

                Assert.IsTrue(resultDto.Count == 2);

                Assert.AreEqual(1, resultDto[0].Id);
                Assert.AreEqual(2, resultDto[1].Id);
                

                Assert.AreEqual(movieName1Action, resultDto[0].Title);
                Assert.AreEqual(movieName2Action, resultDto[1].Title);

                Assert.AreEqual(genreAction, resultDto[0].Genre);
                Assert.AreEqual(genreAction, resultDto[1].Genre);
            }
        }

        [TestMethod]
        public async Task ReturnCorrectMovies_WithSearchStringFiltering()
        {
            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>().
               UseInMemoryDatabase(databaseName: "ReturnCorrectMovies_WithSearchStringFiltering")
               .Options;

            var movieName1 = "Die Hard1";
            var movieName2 = "Die Hard2";
            var movieName3 = "Die Hard3";
            var movieName4 = "Find me";

            var searchString = movieName4;

            var firstMovie = new Movie() { Id = 1, Title = movieName1 };
            var secondMovie = new Movie() { Id = 2, Title = movieName2 };
            var thirdMovie = new Movie() { Id = 3, Title = movieName3 };
            var fourtMovie = new Movie() { Id = 4, Title = movieName4 };

            using (var context = new RazorPagesMovieDbContext(options))
            {
                await context.Movies.AddRangeAsync(firstMovie, secondMovie, thirdMovie, fourtMovie);
                await context.SaveChangesAsync();

                var movieService = new MovieServices.MovieService(context);

                var resultDto = await movieService.GetAllMoviesFiltered(searchString, null);

                Assert.IsTrue(resultDto.Count == 1);

                Assert.AreEqual(4, resultDto[0].Id);
               
                Assert.AreEqual(movieName4, resultDto[0].Title);
                
            }


        }

        [TestMethod]
        public async Task ReturnCorrectMovies_WithSearchStringAndGenreFiltering()
        {
            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>().
               UseInMemoryDatabase(databaseName: "ReturnCorrectMovies_WithSearchStringAndGenreFiltering")
               .Options;

            var movieName1Action = "Die Hard1";
            var movieName2Action = "Die Hard2";
            var movieName3Comedy = "So so funny1";
            var movieName4Comedy = "So so fynny2";

            var genreAction = "Action";
            var genreComedy = "Comedy";

            var searchString = "fynny2";

            var firstMovieAction = new Movie() { Id = 1, Title = movieName1Action, Genre = genreAction };
            var secondMovieAction = new Movie() { Id = 2, Title = movieName2Action, Genre = genreAction };
            var thirdMovieComedy = new Movie() { Id = 3, Title = movieName3Comedy, Genre = genreComedy };
            var fourtMovieComedy = new Movie() { Id = 4, Title = movieName4Comedy, Genre = genreComedy };

            using (var context = new RazorPagesMovieDbContext(options))
            {
                await context.Movies.AddRangeAsync(firstMovieAction, secondMovieAction, thirdMovieComedy, fourtMovieComedy);
                await context.SaveChangesAsync();

                var movieService = new MovieServices.MovieService(context);

                var resultDto = await movieService.GetAllMoviesFiltered(searchString, genreComedy);

                Assert.IsTrue(resultDto.Count == 1);

                Assert.AreEqual(4, resultDto[0].Id);

                Assert.AreEqual(movieName4Comedy, resultDto[0].Title);

                Assert.AreEqual(genreComedy, resultDto[0].Genre);

            }

        }
    }
}
