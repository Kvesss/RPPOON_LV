using System;
using System.Collections.Generic;
using System.Text;

namespace Cist_Kod
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        //private Random randomGenerator; 2.zad

        //public Die(int numberOfSides)         1.zad
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = new Random();
        //}


        public Die( int numberOfSides= 6)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            //int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }

        public int GetNumberOfSides()
        {
            return numberOfSides;
        }

    }
}
