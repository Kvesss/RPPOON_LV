using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
