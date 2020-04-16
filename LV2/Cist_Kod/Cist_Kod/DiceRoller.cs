using System;
using System.Collections.Generic;
using System.Text;

namespace Cist_Kod
{
    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        //private ILogger logger;
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            //this.logger = new ConsoleLogger(); //default logger
        }

        //public DiceRoller(ILogger logger)
        //{
        //    this.logger = logger;
        //    this.dice = new List<Die>();
        //    this.resultForEachRoll = new List<int>();
        //}

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }

        public void PrintDice()
        {
            foreach(int result in resultForEachRoll)
            {
                Console.WriteLine(result);
            }
        }

        //public void LogRollingResults()
        //{
        //    foreach (int result in this.resultForEachRoll)
        //    {
        //        logger.Log(result.ToString());

        //    }
        //}

        //public void SetLogger(ILogger logger)
        //{
        //    this.logger=logger;
        //}

        public string GetStringRepresentation()
        {
            StringBuilder builder = new StringBuilder();
            foreach(int result in resultForEachRoll)
            {
                builder.Append(result.ToString() + "\n");
            }
            return builder.ToString();
        }
    }
}
