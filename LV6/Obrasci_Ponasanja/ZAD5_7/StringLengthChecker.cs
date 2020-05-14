using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class StringLengthChecker : StringChecker
    {
        public StringLengthChecker(int minLength = 8)
        {
            MinLength = minLength;
        }

        public int MinLength { get; }


        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Length >= MinLength;
        }
    }
}
