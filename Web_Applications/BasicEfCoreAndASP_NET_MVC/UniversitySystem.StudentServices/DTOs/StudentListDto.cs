using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.StudentServices.DTOs
{
    public class StudentListDto
    {
        public IEnumerable<StudentDto> Students { get; set; }

        public PageingInfo PagingInfo { get; set; }
    }
}
