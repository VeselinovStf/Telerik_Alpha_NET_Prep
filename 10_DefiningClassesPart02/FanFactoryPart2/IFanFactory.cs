using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart2
{
    public interface IFanFactory
    {
        IFan CreateFan();
    }
}