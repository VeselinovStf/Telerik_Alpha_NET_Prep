using System;

namespace MobilePhone.Mobile
{
    public static class GSMTest
    {
        private static GSM[] gsmTests = new GSM[3];

        public static void TestGsm()
        {
            gsmTests[0] =
                new GSM("Nokia X", "Nokia", 1000, "Pesho",
                new Battery("NBat", 34, 0, BatteryTypes.LiIon),
                new Display(10, 20)
                );

            gsmTests[1] =
                new GSM("Lenovo Y", "Lenovo", 1000, "Ivan",
                new Battery("NBat", 34, 0, BatteryTypes.LiIon),
                new Display(10, 20)
                );

            gsmTests[2] = GSM.IPhoneS;

            gsmTests[0].AddCall("08877777777", 10);

            foreach (var gsm in gsmTests)
            {
                System.Console.WriteLine(gsm);
            }

            Console.WriteLine(gsmTests[0].CalculateCallPrice(100));

            gsmTests[0].ViewCallHistory();
            gsmTests[0].DeleteCall("02313");
            gsmTests[0].DeleteCall("08877777777");
        }
    }
}