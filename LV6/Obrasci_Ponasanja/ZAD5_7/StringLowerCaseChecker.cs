using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            bool hasLowerCase = false;
            foreach (char sign in stringToCheck)
            {
                if (char.IsLower(sign))
                    hasLowerCase = true;
            }
            return hasLowerCase;
        }
    }
}
