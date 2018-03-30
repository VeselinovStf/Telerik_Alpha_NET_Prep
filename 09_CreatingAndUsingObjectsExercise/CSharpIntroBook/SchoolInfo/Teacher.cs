using System.Collections.Generic;
using System.Text;

namespace SchoolInfo
{
    public class Teacher
    {
        private string name;
        private List<Discipline> disciplines;

        public Teacher (string name)
        {
            this.name = name;
            this.disciplines = new List<Discipline> ();
        }

        public string Name { get => name; }
        public List<Discipline> Disciplines { get => disciplines; }

        public void AddDiscipline (string name, int totalLessons, int totalExercises)
        {
            Discipline discipline = new Discipline (name, totalLessons, totalExercises);

            this.disciplines.Add (discipline);
        }

        public override string ToString ()
        {
            StringBuilder result = new StringBuilder ();

            result.AppendLine ("----Teacher Info----");
            result.AppendLine ($"Teacher Name: {this.Name}");
            result.AppendLine ($"Disciplines -----");

            foreach (var discipline in this.disciplines)
            {
                result.AppendLine ($"    {discipline}");
            }

            return result.ToString ();
        }
    }
}