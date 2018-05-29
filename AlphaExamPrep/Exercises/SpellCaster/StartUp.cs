using System;
using System.Linq;
using System.Text;

namespace SpellCaster
{
    public class StartUp
    {
        public static void Main()
        {
            string inputMessage = Console.ReadLine();

            string[] splitedOriginalMessage = inputMessage.Split(' ');

            StringBuilder newMessage = new StringBuilder();

            //Step 1
            while (true)
            {
                if (splitedOriginalMessage.Any(x => x.Length > 0))
                {
                    for (int i = 0; i < splitedOriginalMessage.Length; i++)
                    {
                        if (splitedOriginalMessage[i].Length > 0)
                        {
                            newMessage.Append(splitedOriginalMessage[i].Substring(splitedOriginalMessage[i].Length - 1, 1));
                            splitedOriginalMessage[i] = splitedOriginalMessage[i].Remove(splitedOriginalMessage[i].Length - 1, 1);
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            //Step 2

            //TO DO
            int pointer = 0;
            while (pointer < newMessage.Length)
            {
                char currentLetterToMove = newMessage[pointer];
                int currentLetterMoveIndex = ((Char.ToLower(newMessage[pointer]) - 96) + pointer) % newMessage.Length;

                char temp = newMessage[pointer];
                newMessage.Remove(pointer, 1);
                newMessage.Insert(currentLetterMoveIndex, temp);

                pointer++;
            }

            Console.WriteLine(newMessage.ToString());
        }
    }
}