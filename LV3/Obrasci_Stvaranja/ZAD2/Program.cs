using System;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMatrixGenerator generator = RandomMatrixGenerator.GetInstance();
            double[][] randomMatrix = generator.GenerateRandomMatrix(2, 4);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Math.Round(Convert.ToDecimal(randomMatrix[i][j]), 3) + "\t");
                }
                Console.WriteLine(Environment.NewLine);
            }
            FileLogger logger = FileLogger.GetInstance();
            logger.Log("Test");
            logger.Log("TestTest");
        }
    }
}
