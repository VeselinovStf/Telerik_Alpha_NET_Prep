using System.Collections.Generic;
using UniversitySystem.StudentServices.DTOs;

namespace UniversitySystem.Web.ViewModels.Student
{
    public class StudentListViewModel
    {
        public IEnumerable<StudentViewModel> Students { get; set; }

        public PageingInfo PagingInfo { get; set; }
    }
}
