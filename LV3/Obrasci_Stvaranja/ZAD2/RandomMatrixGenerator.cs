using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD2
{
    class RandomMatrixGenerator
    {
        private static RandomMatrixGenerator instance;
        private Random generator;
        private RandomMatrixGenerator()
        {
            this.generator = new Random();
        }

        public static RandomMatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomMatrixGenerator();
            }
            return instance;
        }

        public double[][] GenerateRandomMatrix(int rows, int cols)
        {
            double[][] randomMatrix = AllocateMatrix(rows, cols);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    randomMatrix[i][j] = generator.NextDouble();
                }
            }
            /*Metoda koja stvara matricu popunjenu pseudo-slučajnim brojevima u ovom slučaju ima
            jednu odgovornost jer je posao alociranja nove matrice prenesen u zasebnu metodu "AllocateMatrix().
            Metoda GenerateRandomMatrix() popunjava tu matricu i vraća ju.*/

            return randomMatrix;
        }
        public double[][] AllocateMatrix(int rows, int cols)
        {
            double[][] Matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                Matrix[i] = new double[cols];
            }
            return Matrix;
        }
    }
}
