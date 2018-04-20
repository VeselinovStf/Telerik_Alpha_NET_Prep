using System;
using System.Collections.Generic;
using System.IO;

namespace School
{
    public class StartUp
    {
        private static Dictionary<string, SchoolClass> classes = new Dictionary<string, SchoolClass>();

        private static void FakeInput()
        {
            string input = @"7
AddClass Purvi
AddClass Vtori
Student Purvi Pesho 23
Student Vtori Ivan 54
Teacher Purvi MIHO Math Literature
Teacher Vtori DOCI Programing Fitness
Print";

            Console.SetIn(new StringReader(input));
        }

        public static void Main()
        {
            FakeInput();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                string command = parameters[0];
                switch (command)
                {
                    case "AddClass":
                        string className = parameters[1];
                        AddClass(className);
                        break;

                    case "Student":
                        string studentClass = parameters[1];
                        string studentName = parameters[2];
                        int studentId = int.Parse(parameters[3]);
                        AddStudent(studentClass, studentName, studentId);
                        break;

                    case "Teacher":
                        string teacherClass = parameters[1];
                        string teacherName = parameters[2];
                        List<Discipline> disciplines = new List<Discipline>();
                        for (int j = 3; j < parameters.Length; j++)
                        {
                            disciplines.Add(new Discipline(parameters[j]));
                        }
                        AddTeacher(teacherClass, teacherName, disciplines);
                        break;

                    case "Print":
                        PrintSchoolInfo();
                        break;

                    default:
                        break;
                }
            }
        }

        private static void PrintSchoolInfo()
        {
            foreach (var clas in classes)
            {
                Console.WriteLine(clas.Value);
            }
        }

        private static void AddTeacher(string teacherClass, string teacherName, List<Discipline> disciplines)
        {
            if (classes.ContainsKey(teacherClass))
            {
                classes[teacherClass].AddTeacher(teacherName);
                classes[teacherClass].AddTeacherDisciplines(teacherName, disciplines);
            }
            else
            {
                Console.WriteLine("This class don't exist!");
            }
        }

        private static void AddStudent(string studentClass, string studentName, int studentId)
        {
            if (classes.ContainsKey(studentClass))
            {
                classes[studentClass].AddStudent(studentName, studentId);
            }
            else
            {
                Console.WriteLine("This class don't exist!");
            }
        }

        private static void AddClass(string className)
        {
            if (!classes.ContainsKey(className))
            {
                classes.Add(className, new SchoolClass(className));
            }
            else
            {
                Console.WriteLine("This class exist!");
            }
        }
    }
}