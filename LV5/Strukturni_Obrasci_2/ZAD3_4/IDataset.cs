using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ZAD3_4
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
