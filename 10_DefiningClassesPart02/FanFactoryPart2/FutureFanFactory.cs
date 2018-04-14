namespace FanFactoryPart2
{
    internal class FutureFanFactory : IFanFactory
    {
        public IFan CreateFan()
        {
            return new FutureFan();
        }
    }
}