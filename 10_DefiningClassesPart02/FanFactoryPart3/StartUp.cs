using System;

namespace FanFactoryPart3
{
    public class StartUp
    {
        public static void Main()
        {
            //IElectricalFactory bulgarianFactory = new BulgarianFactory();
            IElectricalFactory usFactory = new USFactory();

            IFan usFan = usFactory.GetFan();
            usFan.SwitchOn();
        }
    }
}