using System.Collections.Generic;

namespace PhoneINfo
{
    public class GSMTest
    {
        private static List<GSM> gsmList = new List<GSM>();

        static GSMTest()
        {
            GsmList.Add(
                new GSM("NokiaX1", "Nokia", 2323M, "Pesho",
                new Battery("A", 66, 66, BatteryType.Li_Ion),
                new Display(12, 22222)
            ));

            GsmList.Add(
                new GSM("LenovoA2", "Lenovo", 2323M, "Ivan",
                new Battery("A", 100, 66, BatteryType.NiCd),
                new Display(5, 5)
            ));

            GsmList.Add(
                new GSM("S3", "Sanyo", 2323M, "Maria",
                new Battery("A", 66, 66, BatteryType.NuMH),
                new Display(25, 3333333)
            ));
        }

        public static List<GSM> GsmList { get => gsmList; }

        public static string GetIPhoneInfo()
        {
            return GSM.IPhone4S.ToString();
        }
    }
}
