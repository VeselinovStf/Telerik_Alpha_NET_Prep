using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySystem.Web.ViewModels.Student
{
    public class StudentListViewModel
    {
        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
