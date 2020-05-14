using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    abstract class StringChecker
    {
        private StringChecker next;

        public StringChecker GetNext()
        {
            return this.next;
        }

        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.next != null && result == true)
            {
                return this.next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }
}
