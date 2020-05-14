using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    interface IBoxIterator
    {
        Product First();
        Product Next();
        Product Current { get; }
        bool IsDone { get; }
    }
}
