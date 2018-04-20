using System;

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