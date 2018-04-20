namespace FanFactoryPart3
{
    public class USFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new USFan();
        }

        public ITubeLamp GetTubeLamp()
        {
            return new USTubeLamp();
        }
    }
}