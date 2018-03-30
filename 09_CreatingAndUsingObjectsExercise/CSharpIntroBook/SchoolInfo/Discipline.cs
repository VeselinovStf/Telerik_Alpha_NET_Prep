using System.Text;

namespace SchoolInfo
{
    public class Discipline
    {
        private string name;
        private int totalLessons;
        private int totalExercises;

        public Discipline (string name, int totalLessons, int totalExercises)
        {
            this.name = name;
            this.totalLessons = totalLessons;
            this.totalExercises = totalExercises;
        }

        public string Name { get => name; }
        public int TotalLessons { get => totalLessons; }
        public int TotalExercises { get => totalExercises; }

        public override string ToString ()
        {
            StringBuilder result = new StringBuilder ();

            result.AppendLine ($"----Discipline Info----");
            result.AppendLine ($"Discipline name: {this.Name}");
            result.AppendLine ($"Total Lessons: {this.TotalLessons}");
            result.AppendLine ($"Total Exercises: {this.TotalExercises}");
            result.AppendLine ("-------------------");

            return result.ToString ();
        }
    }
}