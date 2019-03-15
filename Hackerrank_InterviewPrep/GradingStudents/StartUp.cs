using System;

namespace GradingStudents
{
    public class StartUp
    {
        public static void Main()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));


        }

        private static int[] gradingStudents(int[] grades)
        {
            Func<int, int, bool> IsLessThen =
                delegate (int number, int compareValue)
                {
                    if (number < compareValue)
                    {
                        return true;
                    }

                    return false;
                };

            Func<int, int, int> CalculateDiff =
                delegate (int a, int b)
                {
                    return a - b;
                };

            Func<int, int> GetNextMultiplier =
                delegate (int n)
                {
                    do
                    {
                        n++;
                    } while (n % 5 != 0);

                    return n;
                };

            for (int i = 0; i < grades.Length; i++)
            {
                var currentGrade = GetNextMultiplier(grades[i]);

                if (currentGrade >= 40)
                {
                    if (IsLessThen(CalculateDiff(currentGrade, grades[i]), 3))
                    {
                        grades[i] = currentGrade;
                    }

                }
            }

            return grades;
        }
    }
}
