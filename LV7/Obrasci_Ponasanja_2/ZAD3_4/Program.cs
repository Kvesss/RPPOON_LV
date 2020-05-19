using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV7\\Obrasci_Ponasanja_2\\ZAD3_4\\FileLogger.txt";
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            Logger consoleLogger = new ConsoleLogger();
            Logger fileLogger = new FileLogger(filePath);
            systemDataProvider.Attach(consoleLogger);
            systemDataProvider.Attach(fileLogger);
            while (true)
            {
                float CPULoad = systemDataProvider.GetCPULoad();
                float AvailableRAM = systemDataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
