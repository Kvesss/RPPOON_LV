using System;

namespace ZAD3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zad 3.
            CareTaker statesCollector = new CareTaker();
            DateTime taskDeadline = new DateTime(2020, 5, 15);
            ToDoItem weekendTask = new ToDoItem("Saturday", "Go to the cinema", taskDeadline);
            statesCollector.PushState(weekendTask.StoreState());
            weekendTask.Rename("Sunday");
            weekendTask.ChangeTask("Watch UFC249");
            Console.WriteLine(weekendTask.ToString());
            weekendTask.RestoreState(statesCollector.PopState());
            Console.WriteLine(weekendTask.ToString());

            //Zad 4.
            Console.WriteLine("=============================");
            BankAccount bankAccount = new BankAccount("John Doe", "Cara Hadrijana 10b", 2000);
            BankAccountMemento memento = bankAccount.StoreState();
            bankAccount.UpdateBalance(500);
            Console.WriteLine(bankAccount.ToString());
            bankAccount.RestoreState(memento);
            Console.WriteLine(bankAccount.ToString());

        }
    }
}
