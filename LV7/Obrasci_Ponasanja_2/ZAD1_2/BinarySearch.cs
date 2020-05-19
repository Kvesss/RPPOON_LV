using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    class BinarySearch : SearchStrategy
    {
        public int Search(double[] array, double target)
        {
            int upperBound = array.Length - 1;
            int lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                int mean = (lowerBound + upperBound) / 2;
                if (array[mean] == target)
                    return mean;
                if (array[mean] < target)
                    lowerBound = mean + 1;
                if (array[mean] > target)
                    upperBound = mean - 1;
            }
            return -1;
        }
    }
}
