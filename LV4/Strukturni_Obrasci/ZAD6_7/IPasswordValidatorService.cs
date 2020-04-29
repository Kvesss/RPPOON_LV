using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
