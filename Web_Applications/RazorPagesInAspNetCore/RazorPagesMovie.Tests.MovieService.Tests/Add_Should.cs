using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RazorPagesMovie.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ValidatorGuard.CustomExceptions;

namespace RazorPagesMovie.Tests.MovieService.Tests
{
    [TestClass]
    public class Add_Should
    {
    

        [TestMethod]
        public async Task Throw_StringIsNullOrWhiteSpaceException_WhenStringTitleIsNull()
        {
            
            string title = null;
            DateTime releaseDate = DateTime.Now;
          
            decimal price = 220m;
            string gender = "Action";

            var dbMock = new Mock<RazorPagesMovieDbContext>();

            var service = new MovieServices.MovieService(dbMock.Object);


            await Assert.ThrowsExceptionAsync<StringIsNullOrWhiteSpaceException>(async () => await service.Add(title, releaseDate, price, gender));
        }

        [TestMethod]
        public async Task Throw_DateTimeIsOldException_WhenDateIsNotCorrect()
        {  
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now;
            
            decimal price = 220m;
            string gender = "Action";

            var dbMock = new Mock<RazorPagesMovieDbContext>();

            var service = new MovieServices.MovieService(dbMock.Object);


            await Assert.ThrowsExceptionAsync<DateTimeIsOldException>(async () => await service.Add( title, releaseDate, price, gender));
        }

        [TestMethod]
        public async Task Throw_LessThenZeroValueException_When_ValueIsLessThenZero()
        {
           
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
            decimal price = -10m;
            string gender = "Action";

            var dbMock = new Mock<RazorPagesMovieDbContext>();

            var service = new MovieServices.MovieService(dbMock.Object);


            await Assert.ThrowsExceptionAsync<LessThenZeroValueException>(async () => await service.Add(title, releaseDate, price, gender));
        }

        [TestMethod]
        public async Task Throw_LessThenZeroValueException_When_ValueIsZero()
        {
            
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
            
            decimal price = 0m;
            string gender = "Action";

            var dbMock = new Mock<RazorPagesMovieDbContext>();

            var service = new MovieServices.MovieService(dbMock.Object);


            await Assert.ThrowsExceptionAsync<LessThenZeroValueException>(async () => await service.Add( title, releaseDate, price, gender));
        }

        [TestMethod]
        public async Task Throw_StringIsNullOrWhiteSpaceException_WhenStringGendersNull()
        {
          
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
           
            decimal price = 220m;
            string gender = null;

            var dbMock = new Mock<RazorPagesMovieDbContext>();

            var service = new MovieServices.MovieService(dbMock.Object);


            await Assert.ThrowsExceptionAsync<StringIsNullOrWhiteSpaceException>(async () => await service.Add(title, releaseDate, price, gender));
        }

        [TestMethod]
        public async Task AddToDatabase_WhenCorrectParametersArePassed()
        {
            
            string title = "DieHard1";
            DateTime releaseDate = DateTime.Now.AddYears(1);
            decimal price = 220m;
            string gender = "Action";

            var options = new DbContextOptionsBuilder<RazorPagesMovieDbContext>()
                .UseInMemoryDatabase(databaseName: "AddToDatabase_WhenCorrectParametersArePassed")
                .Options;

            using (var context = new RazorPagesMovieDbContext(options))
            {
                var service = new MovieServices.MovieService(context);

                await service.Add( title, releaseDate, price, gender);

                var currentMovie = await context.Movies.ToListAsync();

                Assert.AreEqual(1, currentMovie.Count);
              
                Assert.AreEqual(title, currentMovie[0].Title);
                Assert.AreEqual(releaseDate, currentMovie[0].ReleaseDate);
                Assert.AreEqual(price, currentMovie[0].Price);
                Assert.AreEqual(gender, currentMovie[0].Gender);
            }
        }
    }
}
