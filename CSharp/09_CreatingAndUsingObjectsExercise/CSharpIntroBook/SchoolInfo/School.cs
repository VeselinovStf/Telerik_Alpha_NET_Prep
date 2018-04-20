using System.Collections.Generic;
using System.Text;

namespace SchoolInfo
{
    public class School
    {
        private string name;
        private static List<Student> students;
        private static List<Discipline> disciplines;
        private static List<Teacher> teachers;

        public School (string name)
        {
            this.name = name;

            students = new List<Student>();
            disciplines = new List<Discipline>();
            teachers = new List<Teacher>();
        }

        public string Name { get => name; }
        public List<Student> Students { get => students; }
        public List<Discipline> Disciplines { get => disciplines; }
        public List<Teacher> Teachers { get => teachers; }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public  void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public  void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"School \"{this.Name}");
            result.AppendLine("----Teachers List----");
            foreach (var teacher in this.Teachers)
            {
                result.AppendLine(teacher.ToString());
            }
            result.AppendLine("----Disciplines List----");
            foreach (var discipline in this.Disciplines)
            {
                result.AppendLine(discipline.ToString());
            }
            result.AppendLine("----Students List----");
            foreach (var student in this.Students)
            {
                result.AppendLine(student.ToString());
            }

            return result.ToString();
        }
    }
}