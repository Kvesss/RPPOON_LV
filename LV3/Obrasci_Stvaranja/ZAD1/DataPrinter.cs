using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_Stvaranja
{
    class DataPrinter
    {
        public static void ConsolePrint(Dataset dataset)
        {
            foreach (List<string> list in dataset.GetData())
            {
                foreach (string name in list)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
