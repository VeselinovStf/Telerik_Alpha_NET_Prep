using System;
using System.Text;

namespace Numbers
{
    public class StartUp
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            StringBuilder number = new StringBuilder();

            while (!line.Equals("end"))
            {
                string[] parameters = line
                    .Split(new char[] { ' ', '-' }
                    , StringSplitOptions
                    .RemoveEmptyEntries);

                switch (parameters[0])
                {
                    case "set":
                        if (number.Length == 0)
                        {
                            number.Append(parameters[1]);
                        }
                        else
                        {
                            number.Remove(0, number.Length);
                            number.Append(parameters[1]);
                        }
                        break;
                    case "print":
                        Console.WriteLine(number.ToString());
                        break;
                    case "reverse":
                        if (number.Length > 1)
                        {
                            ReverseNumber(number);
                        }                   
                        break;
                    case "front":
                        if (parameters[1] == "add")
                        {
                            number.Insert(0, parameters[2]);
                        }
                        else
                        {
                            if (number.Length > 0)
                            {
                                number.Remove(0, 1);
                            }
                           
                        }
                        break;
                    case "back":
                        if (parameters[1] == "add")
                        {
                            number.Insert(number.Length, parameters[2]);
                        }
                        else
                        {
                            if (number.Length > 0)
                            {
                                number.Remove(number.Length-1, 1);
                            }
                           
                        }
                        break;
                    default:
                        break;
                }

                line = Console.ReadLine();
            }
        }

        private static void ReverseNumber(StringBuilder number)
        {
            string tempNums = number.ToString();
            number.Remove(0, number.Length);
            for (int i = tempNums.Length - 1; i >= 0; i--)
            {
                number.Append(tempNums[i]);
            }
        }
    }
}