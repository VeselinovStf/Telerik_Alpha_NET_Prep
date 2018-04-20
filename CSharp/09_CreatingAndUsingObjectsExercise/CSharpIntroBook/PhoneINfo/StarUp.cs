using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneINfo
{
    public class StarUp
    {
        public static void Main()
        {
            var gsmInfo = GSMTest.GsmList;

            gsmInfo[0].AddCall(DateTime.Now, 2000);
            gsmInfo[0].AddCall(DateTime.Now, 3000);

            gsmInfo[1].AddCall(DateTime.Now, 256);
            gsmInfo[2].AddCall(DateTime.Now, 4000);

            GSM.PriceForMinute = 5.36;

            PrintGsmInfos(gsmInfo);
           
            //var iPhoneInfo = GSMTest.GetIPhoneInfo();

            //Console.WriteLine(iPhoneInfo);
        }

        private static void PrintGsmInfos(List<GSM> gsmInfo)
        {
            foreach (var gsm in gsmInfo)
            {
                Console.WriteLine(gsm);
            }
        }
    }

}
