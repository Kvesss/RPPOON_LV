using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_4
{
    class ConsoleLogger
    {
        private static ConsoleLogger instance;

        private ConsoleLogger()
        {
         
        }

        public static ConsoleLogger GetInstance()
        {
            if(instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
