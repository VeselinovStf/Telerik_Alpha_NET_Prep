using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;
using UniversitySystem.StudentServices.Abstract;
using UniversitySystem.StudentServices.DTOs;
using UniversitySystem.StudentServices.Exceptions;
using ValidatorGuard;

namespace UniversitySystem.StudentServices
{
    public class StudentService : IStudentService
    {
        private readonly UniversitySystemDbContext dbContext;

        public StudentService(UniversitySystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(string FirstMidName, string lastName, DateTime? enrollmentDate)
        {
            Validator.IsStringNotNullOrWhiteSpace(FirstMidName);               
            Validator.IsStringNotNullOrWhiteSpace(lastName);

            var newMovie = new Student()
            {
                
                FirstMidName = FirstMidName,
                LastName = lastName,
                EnrollmentDate = enrollmentDate
            };

            await this.dbContext.Students.AddAsync(newMovie);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<StudentListDto> All()
        {
            var dbQueryEntity = await this.dbContext
                .Students
                .Where(s => !s.IsDeleted)
                .ToListAsync();

            var serviceDto = new StudentListDto()
            {
                Students = dbQueryEntity.Select(s => new StudentDto()
                {
                    Id = s.Id,
                    EnrollmentDate = s.EnrollmentDate,
                    FirstMidName = s.FirstMidName,
                    LastName = s.LastName
                })
            };
                       
            return serviceDto;
        }

        public async Task<StudentDetailsDto> DetailsAsync(int? id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            var dbQueryEntiti = await this.dbContext.Students
                .Include( s => s.Enrollments)
                    .Include("Enrollments.Course")
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

           
            Validator.IsObjectNull(dbQueryEntiti);

            var serviceDto = new StudentDetailsDto()
            {
                Id = dbQueryEntiti.Id,
                EnrollmentDate = dbQueryEntiti.EnrollmentDate,
                FirstMidName = dbQueryEntiti.FirstMidName,
                LastName = dbQueryEntiti.LastName,
                Enrollments = dbQueryEntiti.Enrollments.Select(e => new EnrollmentsDto()
                {
                      Course_Title = e.Course.Title,
                      Enrolment_Grade = e.Grade.ToString()
                }).ToList()               
            };

            return serviceDto;
        }

        public async Task<StudentDto> FirstOrDefaultAsync(int? id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            var dbQueryEntiti = await this.dbContext.Students
                .Where(m => !m.IsDeleted)
                .FirstOrDefaultAsync(m => m.Id == id);

            Validator.IsObjectNull(dbQueryEntiti);

            var serviceDto = new StudentDto()
            {
                Id = dbQueryEntiti.Id,
                EnrollmentDate = dbQueryEntiti.EnrollmentDate,
                  FirstMidName = dbQueryEntiti.FirstMidName,
                   LastName = dbQueryEntiti.LastName
            };

            return serviceDto;
        }

        public async Task Remove(int? id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            var dbQueryEntity = await this.dbContext.Students
                .FindAsync(id);

            if (dbQueryEntity != null)
            {
                dbQueryEntity.IsDeleted = true;

                this.dbContext.Update(dbQueryEntity).State = EntityState.Modified;
                await this.dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(Student student)
        {
            Validator.IsObjectNull(student);

            this.dbContext.Update(student).State = EntityState.Modified;

            try
            {
                await this.dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await StudentExists(student.Id))
                {
                    throw;
                }
                else
                {
                    throw new EntitiNotFoundException();
                }
            }
        }

        private async Task<bool> StudentExists(int id)
        {
            Validator.IsIntegerBiggerThanZero(id);

            return await this.dbContext.Students.AnyAsync(e => e.Id == id);
        }

    }
}
