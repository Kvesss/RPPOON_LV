using System;

namespace ZAD6_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zad 6
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator();
            string emailCandidate = "visual.com";
            string passwordCandidate = "abCD56";

            Console.WriteLine(emailValidator.IsValidAddress(emailCandidate));
            Console.WriteLine(passwordValidator.IsValidPassword(passwordCandidate));

            emailCandidate = "visual@studio.com";
            passwordCandidate = "abCD5678";

            Console.WriteLine(emailValidator.IsValidAddress(emailCandidate));
            Console.WriteLine(passwordValidator.IsValidPassword(passwordCandidate));



            //Zad 7
            RegistrationValidator validator = new RegistrationValidator(5);
            while (true)
            {
                UserEntry entry = UserEntry.ReadUserFromConsole();
                if (validator.IsUserEntryValid(entry))
                {
                    break;
                }
                Console.WriteLine("Invalid entry!\nTry again!\n");
            }
            Console.WriteLine("User entry successful");

        }
    }
}
