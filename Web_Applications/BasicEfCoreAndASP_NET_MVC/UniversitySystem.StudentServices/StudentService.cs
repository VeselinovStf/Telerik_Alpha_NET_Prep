﻿using CustomContentSorter.Abstract;
using CustomPagging;
using Microsoft.EntityFrameworkCore;
using System;
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
        private readonly IPageSort pageSort;
        public int PageSize = 3;

        public StudentService(UniversitySystemDbContext dbContext, IPageSort pageSort)
        {
            this.dbContext = dbContext;
            this.pageSort = pageSort;
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

        public async Task<StudentListDto> All(string sortOrder, string searchString, int pageNumber)
        {
            var dbQueryEntity = await this.dbContext
                .Students
                .Where(s => !s.IsDeleted)
                .OrderBy(s => s.FirstMidName)
                .ToListAsync();

            if (!string.IsNullOrEmpty(sortOrder))
            {
                dbQueryEntity =  this.pageSort.Sort(sortOrder, dbQueryEntity).ToList();
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                dbQueryEntity = dbQueryEntity
                    .Where(s => s.FirstMidName.Contains(searchString)
                                    || s.LastName.Contains(searchString)).ToList();
            }

            
            var paggedQuery = PagingList<Student>.CreateAsync(dbQueryEntity, pageNumber, PageSize);
            
            var serviceDto = new StudentListDto()
            {
                Students = paggedQuery.Select(s => new StudentDto()
                {
                    Id = s.Id,
                    EnrollmentDate = s.EnrollmentDate,
                    FirstMidName = s.FirstMidName,
                    LastName = s.LastName
                }),
                PagingInfo = new PageingInfo()
                {
                     PageIndex = paggedQuery.PageIndex,
                     TotalPages = paggedQuery.TotalPages,                      
                }
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
