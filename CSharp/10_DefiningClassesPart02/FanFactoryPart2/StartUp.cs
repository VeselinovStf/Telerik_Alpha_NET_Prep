namespace FanFactoryPart2
{
    public class StartUp
    {
        public static void Main()
        {
            IFanFactory fanFactory = new FutureFanFactory();

            IFan fan = fanFactory.CreateFan();
            fan.SwitchOn();
        }
    }
}