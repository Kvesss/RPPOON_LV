using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            bool hasNumber = false;
            foreach (char sign in stringToCheck)
            {
                if (char.IsDigit(sign))
                    hasNumber = true;
            }
            return hasNumber;

        }

    }
}
