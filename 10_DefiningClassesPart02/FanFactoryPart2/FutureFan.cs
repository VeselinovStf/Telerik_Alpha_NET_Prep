using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart2
{
    public class FutureFan : IFan
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            Console.WriteLine("Future Fan works in future.");
        }
    }
}
