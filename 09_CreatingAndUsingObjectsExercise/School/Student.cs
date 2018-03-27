namespace School
{
    public class Student
    {
        private string name;
        private static int totalStudents = 0;
        private int uniqueNumber;

        public Student(string name)
        {
            this.name = name;

            totalStudents++;
            this.uniqueNumber = totalStudents;
        }
    }
}
