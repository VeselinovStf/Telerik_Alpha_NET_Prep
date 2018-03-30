using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolInfo;

namespace CSharpIntroBook
{
    public class StartUp
    {
        private const string END_COMMAND = "End";
        private const string WELCOME_MESSAGE = "Welcome to School Data System";
        private const string EXIT_MESSAGE = "Good Bye!";

        private static string[] separators = { ",", ":" };
        static StringBuilder result = new StringBuilder ();

        private static List<School> schools = new List<School> ();

        public static void Main ()
        {
            Console.WriteLine (WELCOME_MESSAGE);
            ReadInput ();
            Console.WriteLine (result.ToString ());
            Console.WriteLine (EXIT_MESSAGE);
        }

        public static void ReadInput ()
        {
            string line;
            line = Console.ReadLine ();

            while (!line.Equals (END_COMMAND))
            {

                string[] expectedCommands = line.Split (separators,
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < expectedCommands.Length; i++)
                {
                    expectedCommands[i] = expectedCommands[i].Trim ();
                }
                ComandExecutes (expectedCommands);
                line = Console.ReadLine ();
            }

        }

        public static void ComandExecutes (string[] expectedCommands)
        {
            switch (expectedCommands[0])
            {
                case "AddSchool":
                    if (schools.Exists (x => x.Name == expectedCommands[1]))
                    {
                        Console.WriteLine ("This school is in the database!");
                    }
                    else
                    {
                        Console.WriteLine ("School Added");
                    }
                    Console.WriteLine (" Added");
                    break;
                case "AddStudent":
                    break;
                case "AddTeacher":
                    break;
                case "AddDiscipline":
                    break;
                case "PrintSchools":
                    break;
                case "PrintStudents":
                    break;
                case "PrintTeachers":
                    break;
                case "PrintDisciplines":
                    break;
                case "PrintAllData":
                    break;
                default:
                    break;
            }
        }
    }

}