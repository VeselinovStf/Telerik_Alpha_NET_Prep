using System;
using System.Collections.Generic;

namespace StudentsInfo
{
    public class StudentTest
    {
        private static List<Student> students;


        static StudentTest()
        {
            students = new List<Student>();
        }

        public static List<Student> Students
        {
            get => students;
            //set => students = value;
        }

        public static void AddStudents(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count must be more then 0");
            }

            for (int i = 0; i < count; i++)
            {
                students.Add(new Student($"Test {i}", $"MidleName", "LastName"));
            }
        }
    }
}
