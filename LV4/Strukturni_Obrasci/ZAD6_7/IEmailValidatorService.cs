using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
