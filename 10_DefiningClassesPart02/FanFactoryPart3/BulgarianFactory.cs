namespace FanFactoryPart3
{
    public class BulgarianFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new BulgarianFan();
        }

        public ITubeLamp GetTubeLamp()
        {
            return new BulgarianTubeLamp();
        }
    }
}