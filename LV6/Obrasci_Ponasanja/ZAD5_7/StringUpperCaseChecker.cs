using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            bool hasUpperCase = false;
            foreach (char sign in stringToCheck)
            {
                if (char.IsUpper(sign))
                    hasUpperCase = true;
            }
            return hasUpperCase;
        }
    }
}
