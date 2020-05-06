using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ZAD3_4
{
    class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private ConsoleLogger logger;
        private Dataset dataset;

        public LoggingProxyDataset(string filePath)
        {
            logger = ConsoleLogger.GetInstance();
            this.filePath = filePath;

        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            string message = GenerateMessage();
            logger.Log(message);
            return dataset.GetData();
        }

        public string GenerateMessage()
        {
            string message = "Login at: " + DateTime.Now;
            return message;
        }
    }
}
