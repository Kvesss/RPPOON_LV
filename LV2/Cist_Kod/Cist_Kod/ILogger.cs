using System;
using System.Collections.Generic;
using System.Text;

namespace Cist_Kod
{
    interface ILogger
    {
        //void Log(string message);
        void Log(ILogable data);
    }
}
