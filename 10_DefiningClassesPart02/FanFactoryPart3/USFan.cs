using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart3
{
    public class USFan : IFan
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            Console.WriteLine("Works NICE");
        }
    }
}
