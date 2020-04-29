using System;

namespace ZAD1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string filePath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV4\\Strukturni_Obrasci\\ZAD1-2\\NUMBERS.txt";
            Dataset data = new Dataset(filePath);
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter analyzerAdapter = new Adapter(analyzer);
            double[] averagesPerRow = analyzerAdapter.CalculateAveragePerRow(data);
            double[] averagesPerColumn = analyzerAdapter.CalculateAveragePerColumn(data);
            foreach(double row in averagesPerRow)
            {
                Console.Write(row + "\t");
            }
            Console.WriteLine(Environment.NewLine);
            foreach (double column in averagesPerColumn)
            {
                Console.Write(column + "\t");
            }

        }
    }
}
