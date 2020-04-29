using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    class RegistrationValidator : IRegistrationValidator
    {
        

        public RegistrationValidator(EmailValidator emailValidator, PasswordValidator passwordValidator)
        {
            this.EmailValidator = emailValidator;
            this.PasswordValidator= passwordValidator;
        }

        public EmailValidator EmailValidator { get; }
        public PasswordValidator PasswordValidator { get; }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return (this.EmailValidator.IsValidAddress(entry.Email) &&
                this.PasswordValidator.IsValidPassword(entry.Password));
        }
    }
}
