namespace School
{
    public class Subject
    {
        private string name;
        private int lessonsCount;
        private int exerciseCount;

        public Subject(string name, int lessonsCount, int exerciseCount)
        {
            this.name = name;
            this.lessonsCount = lessonsCount;
            this.exerciseCount = exerciseCount;
        }

        public string Name { get => name; }
        public int LessonsCount { get => lessonsCount;}
        public int ExerciseCount { get => exerciseCount;  }
    }
}
