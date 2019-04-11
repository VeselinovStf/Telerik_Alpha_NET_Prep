using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Models.Abstract;

namespace UniversitySystem.Models.Entities
{
    public class Student : Entity
    {
        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
