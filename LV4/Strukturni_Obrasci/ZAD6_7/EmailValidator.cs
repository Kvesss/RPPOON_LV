using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {
            if(candidate.Contains('@') && (candidate.EndsWith(".com") || candidate.EndsWith(".hr")))
            {
                return true;
            }
            return false;
        }
    }
}
