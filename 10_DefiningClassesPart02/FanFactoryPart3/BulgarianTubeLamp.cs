using System;

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