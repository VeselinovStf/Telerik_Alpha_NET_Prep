using ContentSorting.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieSystem.Data;
using MovieSystem.MovieServices;
using System;
using System.Threading.Tasks;
using ValidatorGuard.CustomExceptions;

namespace MovieSystem.MovieServiceTests
{
    [TestClass]
    public class Add_should
    {
        [TestMethod]
        public async Task Throw_StringIsNullOrWhiteSpaceException_WhenStringTitleIsNull()
        {

            string title = null;
            DateTime releaseDate = DateTime.Now;

            decimal price = 220m;
            string Genre = "Action";

            var dbMock = new Mock<MovieSystemDbContext>();
            var pageSortMock = new Mock<IPageSort>();
            var service = new MovieServices.MovieService(dbMock.Object, pageSortMock.Object);


            await Assert.ThrowsExceptionAsync<StringIsNullOrWhiteSpaceException>(async () => await service.Add(title, releaseDate, price, Genre));
        }

        [TestMethod]
        public async Task Throw_DateTimeIsOldException_WhenDateIsNotCorrect()
        {
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now;

            decimal price = 220m;
            string Genre = "Action";

            var dbMock = new Mock<MovieSystemDbContext>();
            var pageSortMock = new Mock<IPageSort>();

            var service = new MovieServices.MovieService(dbMock.Object, pageSortMock.Object);


            await Assert.ThrowsExceptionAsync<DateTimeIsOldException>(async () => await service.Add(title, releaseDate, price, Genre));
        }

        [TestMethod]
        public async Task Throw_LessThenZeroValueException_When_ValueIsLessThenZero()
        {

            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
            decimal price = -10m;
            string Genre = "Action";

            var dbMock = new Mock<MovieSystemDbContext>();
            var pageSortMock = new Mock<IPageSort>();

            var service = new MovieServices.MovieService(dbMock.Object, pageSortMock.Object);


            await Assert.ThrowsExceptionAsync<LessThenZeroValueException>(async () => await service.Add(title, releaseDate, price, Genre));
        }

        [TestMethod]
        public async Task Throw_LessThenZeroValueException_When_ValueIsZero()
        {

            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);

            decimal price = 0m;
            string Genre = "Action";

            var dbMock = new Mock<MovieSystemDbContext>();
            var pageSortMock = new Mock<IPageSort>();

            var service = new MovieServices.MovieService(dbMock.Object, pageSortMock.Object);


            await Assert.ThrowsExceptionAsync<LessThenZeroValueException>(async () => await service.Add(title, releaseDate, price, Genre));
        }

        [TestMethod]
        public async Task Throw_StringIsNullOrWhiteSpaceException_WhenStringGenresNull()
        {

            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);

            decimal price = 220m;
            string Genre = null;

            var dbMock = new Mock<MovieSystemDbContext>();
            var pageSortMock = new Mock<IPageSort>();

            var service = new MovieServices.MovieService(dbMock.Object, pageSortMock.Object);


            await Assert.ThrowsExceptionAsync<StringIsNullOrWhiteSpaceException>(async () => await service.Add(title, releaseDate, price, Genre));
        }

        [TestMethod]
        public async Task AddToDatabase_WhenCorrectParametersArePassed()
        {

            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
            decimal price = 220m;
            string Genre = "Action";

            var options = new DbContextOptionsBuilder<MovieSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "AddToDatabase_WhenCorrectParametersArePassed")
                .Options;

            var pageSortMock = new Mock<IPageSort>();

            using (var context = new MovieSystemDbContext(options))
            {
                var service = new MovieService(context,pageSortMock.Object);

                await service.Add(title, releaseDate, price, Genre);

                var currentMovie = await context.Movies.ToListAsync();

                Assert.AreEqual(1, currentMovie.Count);

                Assert.AreEqual(title, currentMovie[0].Title);
                Assert.AreEqual(releaseDate, currentMovie[0].ReleaseDate);
                Assert.AreEqual(price, currentMovie[0].Price);
                Assert.AreEqual(Genre, currentMovie[0].Genre);
            }
        }
    }
}
