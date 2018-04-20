using System;
using System.Collections.Generic;

namespace PhoneINfo
{
    public class GSMCallHistoryTest
    {
        

        public GSMCallHistoryTest(List<GSM> GsmList)
        {
         
            GsmList[0].AddCall(DateTime.Now, 2000);
            GsmList[0].AddCall(DateTime.Now, 3000);
         
            GsmList[1].AddCall(DateTime.Now, 256);

            GsmList[2].AddCall(DateTime.Now, 4000);
        }

        public static double GetAllCalsPrice(List<GSM> GsmList)
        {
            double allCalsPrice = 0;
            foreach (var item in GsmList)
            {
                item.CallPrice(0.37);
            }

            return allCalsPrice;
        }
    }
}
