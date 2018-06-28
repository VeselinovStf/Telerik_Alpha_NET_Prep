using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] expresion = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Stack<int> values = new Stack<int>();

            char lastSign = ' ';

            for (int i = 0; i < expresion.Length; i++)
            {
                int newNumber;

                bool isNumber = int.TryParse(expresion[i], out newNumber);
                if (isNumber)
                {

                    //is digit
                    if (values.Count == 0)
                    {
                        values.Push(newNumber);
                    }
                    else
                    {
                        var lastNumber = values.Pop();

                        if (lastSign == '+')
                        {
                            var newValue = lastNumber + newNumber;
                            values.Push(newValue);
                        }
                        else
                        {
                            var newValue = lastNumber - newNumber;
                            values.Push(newValue);
                        }
                    }
                    
                }
                else
                {
                    lastSign = char.Parse(expresion[i]);
                }

                
            }

            Console.WriteLine(values.Pop());
        }
    }
}
