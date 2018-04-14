﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FanFactoryPart3
{
    public interface IElectricalFactory
    {
        IFan GetFan();
        ITubeLamp GetTubeLamp();
    }
}
