using System;
using System.Collections.Generic;
using System.Text;

namespace Cist_Kod
{
    class ConsoleLogger : ILogger
    {
        //public void Log(string message)
        //{
        //    Console.WriteLine(message);
        //}
        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
