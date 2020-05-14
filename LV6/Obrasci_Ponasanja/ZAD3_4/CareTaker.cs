using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_4
{
    class CareTaker
    {
        public Stack<Memento> PreviousStates;

        public CareTaker()
        {
            PreviousStates = new Stack<Memento>();
        }
        
        public Memento PopState()
        {
            return PreviousStates.Pop();
        }
        public Memento PeekState()
        {
            return PreviousStates.Peek();
        }

        public void PushState(Memento lastVersion)
        {
            PreviousStates.Push(lastVersion);
        }
    }
}
