using System;
using System.Collections.Generic;

namespace Cist_Kod
{
    class Program
    {
        static int numberOfSides = 6;
        static void Main(string[] args)
        {
            //1.zad

            //DiceRoller roller = new DiceRoller();
            //for(int counter = 0; counter < 20; counter++)
            //{
            //    roller.InsertDie(new Die(numberOfSides));
            //}
            //roller.RollAllDice();
            //IList<int> rollingResults = roller.GetRollingResults();
            //for (int counter = 0; counter < rollingResults.Count; counter++)
            //{
            //    Console.WriteLine(rollingResults[counter]);
            //}
            //roller.PrintDice();


            //2.zad

            //Random randomGenerator = new Random();
            //DiceRoller roller = new DiceRoller();
            //for (int counter = 0; counter < 20; counter++)
            //{
            //    roller.InsertDie(new Die(randomGenerator));
            //}
            //roller.RollAllDice();
            //IList<int> rollingResults = roller.GetRollingResults();
            //for (int counter = 0; counter < rollingResults.Count; counter++)
            //{
            //    Console.WriteLine(rollingResults[counter]);
            //}
            //roller.PrintDice();


            //3.zad

            //RandomGenerator randomGenerator = RandomGenerator.GetInstance();
            DiceRoller roller = new DiceRoller();
            for (int counter = 0; counter < 20; counter++)
            {
                roller.InsertDie(new Die());
            }
            roller.RollAllDice();
            //IList<int> rollingResults = roller.GetRollingResults();
            //for (int counter = 0; counter < rollingResults.Count; counter++)
            //{
            //    Console.WriteLine(rollingResults[counter]);
            //}
            roller.PrintDice();


        }
    }
}
