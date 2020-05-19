using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    class LinearSearch : SearchStrategy
    {
        public int Search(double[] array, double target)
        {
            for(int i=0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
