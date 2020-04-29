
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZAD1_2
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int columns = data[0].Length;
            double[] results = new double[columns];
            for(int i=0; i < columns; i++)
            {
                for(int j=0; j < data.Length; j++)
                {
                    results[i] += data[j][i];
                }
                results[i] = Math.Round(results[i] / data.Length, 5);  //Unusual values appear without Math.Round() method, e.g.(1.3999999999999997)
            }
            return results;
        }

    }
}
