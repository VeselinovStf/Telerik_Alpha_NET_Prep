using System.Collections.Generic;

namespace School
{
    public class SchoolClass
    {
        private string className;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string className, List<Student> students, List<Teacher> teachers)
        {
            this.className = className;

            this.students = new List<Student>();
            this.teachers = new List<Teacher>();

            this.students = students;
            this.teachers = teachers;
        }

        public List<Student> Students { get => students;  }
        public List<Teacher> Teachers { get => teachers;  }
    }
}
