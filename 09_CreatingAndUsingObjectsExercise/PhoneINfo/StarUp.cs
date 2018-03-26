using System;

namespace PhoneINfo
{
    public class StarUp
    {
        public static void Main()
        {
            GSM gsm = new GSM("Test","T",2323M,"PEsho", 
                new Battery("A",66,66,BatteryType.Li_Ion), 
                new Display(12,22222) );
            Console.WriteLine(gsm);

        }
    }

}
