using System;
using System.Collections;
using System.Collections.Generic;

namespace Obrasci_Stvaranja
{
    class Program
    {
        static void Main(string[] args)
        {
            String filepath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV3\\Obrasci_Stvaranja\\ZAD1\\LV3_ZAD1.txt";
            Dataset dataset = new Dataset(filepath);
            IList<List<string>> data = dataset.GetData();
            DataPrinter.ConsolePrint(dataset);
            Dataset dataCopy = (Dataset)dataset.Clone();
            DataPrinter.ConsolePrint(dataCopy);
            
        }
    }
}
