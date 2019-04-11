using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Models.Abstract;

namespace UniversitySystem.Models.Entities
{
    public class Course : Entity
    {
        public Course()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
