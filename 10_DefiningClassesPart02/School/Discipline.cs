namespace School
{
    public class Discipline
    {
        private string name;
        private int totalHours;
        private int exerciseHours;

        public Discipline(string name)
        {
            this.name = name;
        }

        public Discipline(string name, int totalHours) : this(name)
        {
            this.totalHours = totalHours;
        }

        public Discipline(string name, int totalHours, int exerciseHours) : this(name, totalHours)
        {        
            this.exerciseHours = exerciseHours;
        }

        public string Name { get => name; }
        public int TotalHours { get => totalHours;}
        public int ExerciseHours { get => exerciseHours; }
    }
}