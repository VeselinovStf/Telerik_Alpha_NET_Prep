using System;
using System.Collections.Generic;
using System.Text;

namespace FanIndustry
{
    public class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType fantype)
        {
            switch (fantype)
            {
                case FanType.BasicFan:
                    return new BasicFan();

                case FanType.ModernFan:
                    return new ModernFan();

                case FanType.UltraFan:
                    return new UltraFan();

                default:
                    return new BasicFan();
            }
        }
    }
}