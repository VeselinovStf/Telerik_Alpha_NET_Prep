using System.Linq;

namespace Day_12_Inheritance
{
    internal class Student : Person
    {
        private int[] testScores;
        private int[] scores;

        /*
    *   Class Constructor
    *
    *   Parameters:
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */

        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            this.scores = scores;
        }

        /*
       *   Method Name: Calculate
       *   Return: A character denoting the grade.
       */

        public string Calculate()
        {
            var avarage = scores.Average();

            string result = string.Empty;

            if (avarage >= 90 && avarage <= 100)
            {
                result = "O";
            }
            else if (avarage >= 80 && avarage < 90)
            {
                result = "E";
            }
            else if (avarage >= 70 && avarage < 80)
            {
                result = "A";
            }
            else if (avarage >= 55 && avarage < 70)
            {
                result = "P";
            }
            else if (avarage >= 40 && avarage < 55)
            {
                result = "D";
            }
            else
            {
                result = "T";
            }

            return result;
        }
    }
}