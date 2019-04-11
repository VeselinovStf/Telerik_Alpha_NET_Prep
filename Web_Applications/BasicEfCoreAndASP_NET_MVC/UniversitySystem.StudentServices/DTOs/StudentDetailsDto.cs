using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.StudentServices.DTOs
{
    public class StudentDetailsDto
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public IList<EnrollmentsDto> Enrollments { get; set; }

        
    }
}
