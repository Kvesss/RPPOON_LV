using System;
using System.Collections.Generic;
using System.Text;

namespace Cist_Kod
{
    interface IFlexibleDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
