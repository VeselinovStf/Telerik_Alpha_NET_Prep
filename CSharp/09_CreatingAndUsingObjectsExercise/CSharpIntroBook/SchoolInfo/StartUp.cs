using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CSharpIntroBook.Constance;
using SchoolInfo;

namespace CSharpIntroBook
{
    public class StartUp
    {
        
        private static string[] separators = { ",", ":", "(",")"};
        static StringBuilder result = new StringBuilder ();

        private static Dictionary<string, School> schools = new Dictionary<string, School>();

        public static void FakeInput()
        {
            StringBuilder result = new StringBuilder();
            StreamReader reader = new StreamReader("../../../testInput.txt");
            using (reader)
            {             
                string line = reader.ReadLine();

                while (line != null)
                {
                    result.AppendLine(line);
                    line = reader.ReadLine();
                }
               
            }

            Console.SetIn(new StringReader(result.ToString()));
        }

        public static void Main ()
        {
            FakeInput();
            result.AppendLine(ConstMessages.WELCOME_MESSAGE);
            ReadInput ();
            result.AppendLine(ConstMessages.EXIT_MESSAGE);
            Console.WriteLine (result.ToString ());
            
            
        }

        public static void ReadInput ()
        {
            string line;
            line = Console.ReadLine ();

            while (!line.Equals (ConstMessages.END_COMMAND))
            {
                
                string[] command = SpliStringToArray(line);

                ComandExecutes (command);
                line = Console.ReadLine ();
            }

        }

        private static string[] SpliStringToArray(string line)
        {
            string[] command = line.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);

            return command;
        }

        public static void ComandExecutes (string[] parameters)
        {
            string command = parameters[0];
            if (command != "PrintAllData")
            {
                string schoolName = parameters[1];

                switch (command)
                {
                    case "AddSchool":                       
                        if (schools.ContainsKey(schoolName))
                        {
                            result.AppendLine(ConstMessages.SCHOOL_EXIST_MESSAGE);
                        }
                        else
                        {
                            schools.Add(schoolName, new School(schoolName));
                            result.AppendLine(ConstMessages.SCHOOL_CREATED_MESSAGE);
                        }
                        break;
                    case "AddStudent":
                        if (schools.ContainsKey(schoolName))
                        {                         
                            Student student = new Student(parameters[2], int.Parse(parameters[3]));

                            schools[schoolName].AddStudent(student);
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "AddTeacher":
                        if (schools.ContainsKey(schoolName))
                        {
                            Teacher teacher = new Teacher(parameters[2]);
                            
                            for (int i = 3; i < parameters.Length; i++)
                            {
                                teacher.AddTeacherDiscipline(new Discipline(parameters[i]));
                            }
                            schools[schoolName].AddTeacher(teacher);
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "AddDiscipline":
                        if (schools.ContainsKey(schoolName))
                        {
                            Discipline discipline = new Discipline(parameters[2], int.Parse(parameters[3]), int.Parse(parameters[4]));

                            schools[schoolName].AddDiscipline(discipline);
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "Print":
                        if (schools.ContainsKey(schoolName))
                        {
                            foreach (var school in schools.Where(x => x.Key == schoolName))
                            {
                                result.AppendLine(school.Value.ToString());
                            }
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "PrintStudents":
                        if (schools.ContainsKey(schoolName))
                        {
                            foreach (var school in schools.Where(x => x.Key == schoolName))
                            {
                                result.AppendLine(school.Value.Students.ToString());
                            }
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "PrintTeachers":
                        if (schools.ContainsKey(schoolName))
                        {
                            foreach (var school in schools.Where(x => x.Key == schoolName))
                            {
                                foreach (var teacher in school.Value.Teachers)
                                {
                                    result.AppendLine(teacher.ToString());
                                }
                            }
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;
                    case "PrintDisciplines":
                        if (schools.ContainsKey(schoolName))
                        {
                            foreach (var school in schools.Where(x => x.Key == schoolName))
                            {
                                foreach (var discipline in school.Value.Disciplines)
                                {
                                    result.AppendLine(discipline.ToString());
                                }
                               
                            }
                        }
                        else
                        {
                            result.AppendLine(ConstMessages.SCHOOL_DOESNTEXIST_MESSAGE);
                        }
                        break;                   
                    default:
                        break;
                }
            }
            else
            {
                foreach (var school in schools)
                {
                    result.AppendLine(school.Value.ToString());
                }
            }
            
        }
    }

}