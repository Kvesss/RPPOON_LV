using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_5
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
