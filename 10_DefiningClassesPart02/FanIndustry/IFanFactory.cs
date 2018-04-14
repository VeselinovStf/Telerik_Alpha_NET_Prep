namespace FanIndustry
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType fantype);
    }
}