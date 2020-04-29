using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);

    }
}
