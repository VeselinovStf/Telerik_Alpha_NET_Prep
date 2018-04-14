using System;

/// <summary>
/// Source: https://www.codeproject.com/Articles/1131770/Factory-Patterns-Simple-Factory-Pattern
/// </summary>
namespace FanIndustry
{
    public class StartUp
    {
        public static void Main()
        {
            IFanFactory simpleFactory = new FanFactory();
            IFan fan = simpleFactory.CreateFan(FanType.UltraFan);

            fan.SwitchOn();
        }
    }
}