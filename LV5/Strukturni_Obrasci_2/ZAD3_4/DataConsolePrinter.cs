using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ZAD3_4
{
    class DataConsolePrinter
    {
        public void Print(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> tempDataset = dataset.GetData();  
            if (IsNull(tempDataset))
            {
                Console.WriteLine("Dataset is unavailable!");
            }
            else
            {
                foreach (List<string> data in tempDataset)
                {
                    foreach (string unit in data)
                    {
                        Console.Write(unit + ", ");
                    }
                    Console.Write(Environment.NewLine);
                }
            }
                
        }

        public bool IsNull(ReadOnlyCollection<List<string>> dataset)
        {
            return dataset == null;
        }
    }
}
