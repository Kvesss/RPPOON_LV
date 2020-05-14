using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
