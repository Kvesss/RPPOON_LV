using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
}
