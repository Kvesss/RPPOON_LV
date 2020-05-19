using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD7
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD DVDItem = new DVD("Visual Studio 2019", DVDType.SOFTWARE, 999.99);
            VHS VHSItem = new VHS("Super Mario", 49.99);
            Book BookItem = new Book("Clean Code", 199.99);
            Console.WriteLine(DVDItem.ToString());
            Console.WriteLine(VHSItem.ToString());
            Console.WriteLine(BookItem.ToString());
            RentVisitor visitor = new RentVisitor();

            Cart itemCart = new Cart();
            itemCart.AddItem(DVDItem);
            itemCart.AddItem(VHSItem);
            itemCart.AddItem(BookItem);
            Console.WriteLine("Total price: "+ itemCart.Accept(visitor));
            Console.ReadLine();
        }
    }
}
