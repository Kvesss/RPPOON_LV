using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            double[][] convertedData = AllocateData(dataset);
            for(int i = 0; i < convertedData.Length; i++)
            {
                for(int j = 0; j < convertedData[i].Length; j++)
                {
                    convertedData[i][j] = dataset.GetData()[i][j];
                }
            }
            return convertedData;


        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }

        public double[][] AllocateData(Dataset dataset)
        {
            IList<List<double>> tempData = dataset.GetData();
            double[][] allocatedData = new double[tempData.Count][];
            for (int i = 0; i < tempData.Count; i++)
            {
                int columns = tempData[i].Count;
                allocatedData[i] = new double[columns];
            }
            return allocatedData;
        }
    }
}
