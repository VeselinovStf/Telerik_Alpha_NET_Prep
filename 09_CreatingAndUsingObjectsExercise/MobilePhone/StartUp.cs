/*
 * Creating and Using Objects
 *
 * See README.md for more Info
 *
 */

using MobilePhone.Mobile;
using System;

namespace MobilePhone
{
    public class StartUp
    {
        private static void Main()
        {
            GSM gsm = new GSM("s", "s", 2);

            Console.WriteLine(gsm);

            gsm.Price -= 10;
        }
    }
}