﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5_7
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}