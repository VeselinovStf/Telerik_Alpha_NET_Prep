using System;

namespace FanIndustry
{
    public class UltraFan : IFan
    {
        public void SwitchOff()
        {
            throw new NotImplementedException();
        }

        public void SwitchOn()
        {
            Console.WriteLine("Ultra fan is On!");
        }
    }
}