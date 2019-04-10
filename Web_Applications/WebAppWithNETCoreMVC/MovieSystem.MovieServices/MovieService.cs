using Microsoft.EntityFrameworkCore;
using MovieSystem.Data;
using MovieSystem.Models;
using MovieSystem.MovieServices.Abstract;
using MovieSystem.MovieServices.DTOs;
using MovieSystem.MovieServices.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidatorGuard;

namespace MovieSystem.MovieServices
{
    public class MovieService : IMovieService
    {
        private readonly MovieSystemDbContext dbContext;

        public MovieService(MovieSystemDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task Add(string title, DateTime releaseDate, decimal price, string Genre)
        {

            Validator.IsStringNotNullOrWhiteSpace(title);
            Validator.IsDateNotBiggerThanCorrent(releaseDate);
            Validator.IsDecimalBiggerThanZero(price);
            Validator.IsStringNotNullOrWhiteSpace(Genre);

            var newMovie = new Movie()
            {

                Title = title,
                ReleaseDate = releaseDate,
                Price = price,
                Genre = Genre
            };

            await this.dbContext.Movies.AddAsync(newMovie);
            await this.dbContext.SaveChangesAsync();
        }


        public async Task Update(Movie movie)
        {
            Validator.IsObjectNull(movie);

            this.dbContext.Update(movie).State = EntityState.Modified;

            try
            {
                await this.dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await MovieExists(movie.Id))
                {
                    throw;
                }
                else
                {
                    throw new EntitiNotFoundException();
                }
            }
        }

        private async Task<bool> MovieExists(int id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            return await this.dbContext.Movies.AnyAsync(e => e.Id == id);
        }

        public async Task<IList<MovieDto>> AllFiltered(string searchString, string movieGenre)
        {
            var moviesDbQueryEntities = dbContext.Movies
                .OrderBy(m => m.Genre)
                .Where(s => !s.IsDeleted)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                moviesDbQueryEntities = moviesDbQueryEntities
                    .Where(s => s.Title.Contains(searchString) && !s.IsDeleted);
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                moviesDbQueryEntities = moviesDbQueryEntities
                    .Where(m => m.Genre == movieGenre && !m.IsDeleted)
                    .Distinct();
            }

            var filteredAllMovies = await moviesDbQueryEntities.ToListAsync();

            var serviceModelDto = filteredAllMovies.Select(m => new MovieDto()
            {
                Id = m.Id,
                Title = m.Title,
                ReleaseDate = m.ReleaseDate,
                Genre = m.Genre,
                Price = m.Price
            }).ToList();

            return serviceModelDto;
        }



        public async Task<MovieDto> FirstOrDefaultAsync(int? id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            var dbQueryEntiti = await this.dbContext.Movies
                .Where(m => !m.IsDeleted)
                .FirstOrDefaultAsync(m => m.Id == id);

            Validator.IsObjectNull(dbQueryEntiti);

            var serviceDto = new MovieDto()
            {
                Id = dbQueryEntiti.Id,
                Title = dbQueryEntiti.Title,
                ReleaseDate = dbQueryEntiti.ReleaseDate,
                Genre = dbQueryEntiti.Genre,
                Price = dbQueryEntiti.Price
            };

            return serviceDto;
        }

        public async Task Remove(int? id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            var dbQueryEntity = await this.dbContext.Movies
                .FindAsync(id);

            if (dbQueryEntity != null)
            {
                dbQueryEntity.IsDeleted = true;
                await this.dbContext.SaveChangesAsync();
            }
        }
    }
}
