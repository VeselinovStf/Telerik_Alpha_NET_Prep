using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySystem.Web.ViewModels.Student
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public DateTime? EnrollmentDate { get; set; }
    }
}
