using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart3
{
    public class BulgarianTubeLamp : ITubeLamp
    {
        public void SwitchOn()
        {
            Console.WriteLine("Bulgarian Lamp Burns Red");
        }
    }
}