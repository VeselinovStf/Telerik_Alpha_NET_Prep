using System.Text;

namespace SchoolInfo
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student (string name, int uniqueNumber)
        {
            this.name = name;
            this.uniqueNumber = uniqueNumber;
        }
        public string Name { get => name; }
        public int UniqueNumber { get => uniqueNumber; }

        public override string ToString ()
        {
            StringBuilder result = new StringBuilder ();

            result.AppendLine ($"----Student Info----");
            result.AppendLine ($"Student name: {this.Name}");
            result.AppendLine ($"Studend Number: {this.UniqueNumber}");
            result.AppendLine ("-------------------");

            return result.ToString ();
        }
    }
}