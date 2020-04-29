﻿using System;

namespace ZAD6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationValidator validator = new RegistrationValidator(new EmailValidator(), new PasswordValidator());
            while (true)
            {
                UserEntry entry = UserEntry.ReadUserFromConsole();
                if (validator.IsUserEntryValid(entry))
                {
                    break;
                }
                Console.WriteLine("Invalid entry!\nTry again!\n");
            }
            Console.WriteLine("User entry successful!");

        }
    }
}
