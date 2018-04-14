using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher : Human
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Teacher Name : {this.Name}");
            foreach (var discipline in disciplines)
            {
                result.AppendLine($"Discipline name : {discipline.Name}");
                result.AppendLine($"Total Learning Hours: {discipline.TotalHours}");
                result.AppendLine($"Total hours of exercises : {discipline.ExerciseHours}");
            }

            return result.ToString();
        }
    }
}
