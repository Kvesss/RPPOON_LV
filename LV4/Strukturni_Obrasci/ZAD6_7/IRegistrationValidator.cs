using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    interface IRegistrationValidator
    {
        public EmailValidator EmailValidator { get { return EmailValidator; } }
        public PasswordValidator PasswordValidator { get { return PasswordValidator; }}
        bool IsUserEntryValid(UserEntry entry);
    }
}
