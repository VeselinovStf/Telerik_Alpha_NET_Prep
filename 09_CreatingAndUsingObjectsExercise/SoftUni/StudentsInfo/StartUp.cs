using System;

namespace StudentsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter student count: ");
            int count = int.Parse(Console.ReadLine());

            try
            {
                StudentTest.AddStudents(count);

                var studentsList = StudentTest.Students;

                foreach (var student in studentsList)
                {
                    Console.WriteLine(student);
                }

                Console.WriteLine("Total Students Count: " + Student.StudentsCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
