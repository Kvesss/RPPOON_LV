using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zad 5
            DVD DVDItem = new DVD("The Last Dance", DVDType.MOVIE, 99.99);
            VHS VHSItem = new VHS("Super Mario", 49.99);
            Book BookItem = new Book("Clean Code", 199.99);
            Console.WriteLine(DVDItem.ToString());
            Console.WriteLine(VHSItem.ToString());
            Console.WriteLine(BookItem.ToString());

            BuyVisitor visitor = new BuyVisitor();
            Console.WriteLine(DVDItem.Accept(visitor));
            Console.WriteLine(VHSItem.Accept(visitor));
            Console.WriteLine(BookItem.Accept(visitor));
            Console.ReadLine();


            //Zad 6
            RentVisitor rentVisitor = new RentVisitor();
            Console.WriteLine(DVDItem.Accept(rentVisitor));
            Console.WriteLine(VHSItem.Accept(rentVisitor));
            Console.WriteLine(BookItem.Accept(rentVisitor));
            Console.ReadLine();
        }
    }
}
