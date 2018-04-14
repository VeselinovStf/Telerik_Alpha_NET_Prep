using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart3
{
    public class BulgarianFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("This can't be turn off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("This never works!");
        }
    }
}