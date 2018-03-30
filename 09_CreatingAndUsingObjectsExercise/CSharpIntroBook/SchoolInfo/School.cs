using System.Collections.Generic;

namespace SchoolInfo
{
    public class School
    {
        private string name;
        private List<Student> students;
        private List<Discipline> disciplines;
        private List<Teacher> teachers;

        public School (string name)
        {
            this.name = name;

        }

        public string Name { get => name; }
        public List<Student> Students { get => students; }
        public List<Discipline> Disciplines { get => disciplines; }
        public List<Teacher> Teachers { get => teachers; }
    }
}