using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Models.Abstract;
using UniversitySystem.Models.Common;

namespace UniversitySystem.Models.Entities
{
    public class Enrollment : Entity
    {
        public Grade? Grade { get; set; }

        public int Course_Id { get; set; }

        public Course Course { get; set; }
        public int Student_Id { get; set; }

        public Student Student { get; set; }
    }
}
