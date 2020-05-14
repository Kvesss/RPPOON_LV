using System;

namespace ZAD5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            string filepath = "D:\\Git\\RPPOON\\RPPOON_LV\\LV6\\Obrasci_Ponasanja\\ZAD5_7\\messages.txt";
            FileLogger fileLogger =
           new FileLogger(MessageType.ERROR | MessageType.WARNING, filepath);

            //Zad 5.
            Console.WriteLine("=========ZAD 5===========");

            logger.SetNextLogger(fileLogger);
            logger.Log("That's all she wrote", MessageType.WARNING);
            logger.Log("That's all she wrote", MessageType.INFO);
            logger.Log("That's all she wrote", MessageType.ERROR);

            //Zad 6.
            Console.WriteLine("=========ZAD 6===========");

            StringChecker stringChecker = new StringLengthChecker();
            StringChecker digitChecker = new StringDigitChecker();
            stringChecker.SetNext(digitChecker);
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            digitChecker.SetNext(upperCaseChecker);
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();
            upperCaseChecker.SetNext(lowerCaseChecker);
            string firstTestString = "HelloWorld";
            string secondTestString = "HelloWorld!High5!";
            if (stringChecker.Check(firstTestString))
                Console.WriteLine("String is valid!");
            else
                Console.WriteLine("String is invalid!");
            if (stringChecker.Check(secondTestString))
                Console.WriteLine("String is valid!");
            else
                Console.WriteLine("String is invalid!");

            //Zad 7.

            Console.WriteLine("=========ZAD 7===========");
            PasswordValidator validator = new PasswordValidator(stringChecker);
            if (validator.Check(firstTestString))
                Console.WriteLine("String is valid!");
            else
                Console.WriteLine("String is invalid!");
            if (validator.Check(secondTestString))
                Console.WriteLine("String is valid!");
            else
                Console.WriteLine("String is invalid!");


        }

    }
}
