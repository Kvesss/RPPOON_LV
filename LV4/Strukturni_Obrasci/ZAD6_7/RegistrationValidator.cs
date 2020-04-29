using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD6_7
{
    class RegistrationValidator : IRegistrationValidator
    {
        public EmailValidator EmailValidator { get; }
        public PasswordValidator PasswordValidator { get; }

        public RegistrationValidator(int minLength = 8)
        {
            this.EmailValidator = new EmailValidator();
            this.PasswordValidator= new PasswordValidator(minLength);
        }


        public bool IsUserEntryValid(UserEntry entry)
        {
            return (this.EmailValidator.IsValidAddress(entry.Email) &&
                this.PasswordValidator.IsValidPassword(entry.Password));
        }
    }
}
