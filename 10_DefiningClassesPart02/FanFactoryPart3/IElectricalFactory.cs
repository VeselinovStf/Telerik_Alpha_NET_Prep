namespace FanFactoryPart3
{
    public interface IElectricalFactory
    {
        IFan GetFan();

        ITubeLamp GetTubeLamp();
    }
}