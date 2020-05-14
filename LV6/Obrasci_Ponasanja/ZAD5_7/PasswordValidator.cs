using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class PasswordValidator
    {
        private StringChecker firstChecker;
        private StringChecker lastChecker;

        public PasswordValidator(StringChecker firstChecker)
        {
            this.firstChecker = firstChecker;
            StringChecker tempChecker = firstChecker;
            while (tempChecker.GetNext() != null)
            {
                tempChecker = tempChecker.GetNext();
            }
            this.lastChecker = tempChecker;
        }


        public void SetNext(StringChecker newChecker)
        {
            lastChecker.SetNext(newChecker);
            StringChecker tempChecker = newChecker;
            while (tempChecker.GetNext() != null)
            {
                tempChecker = tempChecker.GetNext();
            }
            this.lastChecker = tempChecker;
        }

        public bool Check(string password)
        {
            return firstChecker.Check(password);
        }
    }
}
