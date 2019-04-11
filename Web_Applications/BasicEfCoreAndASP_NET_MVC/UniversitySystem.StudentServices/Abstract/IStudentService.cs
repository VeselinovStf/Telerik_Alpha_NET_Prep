using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models.Entities;
using UniversitySystem.StudentServices.DTOs;

namespace UniversitySystem.StudentServices.Abstract
{
    public interface IStudentService
    {
        Task<StudentListDto> All();

        Task Add(string FirstMidName, string lastName, DateTime? enrollmentDate);
        Task<StudentDto> FirstOrDefaultAsync(int? id);

        Task Remove(int? id);
        Task Update(Student student);
    }
}
