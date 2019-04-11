using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.StudentServices.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public DateTime? EnrollmentDate { get; set; }
    }
}
