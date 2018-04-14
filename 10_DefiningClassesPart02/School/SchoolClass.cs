using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class SchoolClass
    {
        private string name;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();          
        }

        public void AddStudent(string studentName, int studentId)
        {
            this.students.Add(new Student(studentName, studentId));
        }

        public void AddTeacher(string teacherName)
        {
            this.teachers.Add(new Teacher(teacherName));
        }

        public void AddTeacherDisciplines(string teacherName,List<Discipline> disciplines)
        {
            foreach (var teacher in teachers.Where(x => x.Name == teacherName))
            {
                foreach (var discipline in disciplines)
                {
                    teacher.AddDiscipline(discipline);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.name);
            result.AppendLine("Students in class");
            foreach (var student in students)
            {
                result.AppendLine(student.ToString());
            }
            result.AppendLine("Teachers in class");
            foreach (var teacher in teachers)
            {
                result.AppendLine(teacher.ToString());
            }

            return result.ToString();
        }
    }
}
