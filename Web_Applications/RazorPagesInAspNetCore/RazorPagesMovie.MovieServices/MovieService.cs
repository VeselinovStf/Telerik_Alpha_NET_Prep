using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using RazorPagesMovie.MovieServices.Abstract;
using RazorPagesMovie.MovieServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidatorGuard;

namespace RazorPagesMovie.MovieServices
{
    public class MovieService : IMovieService
    {
        private readonly RazorPagesMovieDbContext dbContext;

        public MovieService(RazorPagesMovieDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task Add( string title, DateTime releaseDate, decimal price, string Genre)
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


        public async Task Edit(Movie movie)
        {
            Validator.IsObjectNull(movie);

            this.dbContext.Attach(movie).State = EntityState.Modified;

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

        public async Task<IList<MovieDto>> GetAll()
        {
            var dbQueryEntities = await dbContext.Movies
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            var serviceModelDto = dbQueryEntities.Select(m => new MovieDto()
            {
                Id = m.Id,
                Title = m.Title,
                ReleaseDate = m.ReleaseDate,
                Genre = m.Genre,
                Price = m.Price
            }).ToList();

            return serviceModelDto;
        }

        public async Task<MovieDto> GetById(int? id)
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

        public async Task RemoveMovie(int? id)
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
