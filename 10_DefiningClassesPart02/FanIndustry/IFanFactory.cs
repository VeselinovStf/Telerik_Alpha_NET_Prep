using System;
using System.Collections.Generic;
using System.Text;

namespace FanIndustry
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType fantype);
    }
}