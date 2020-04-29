using System;
using System.Collections.Generic;

namespace ZAD3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad 3
            RentingConsolePrinter consolePrinter = new RentingConsolePrinter(); 
            List<IRentable> items = new List<IRentable>();
            items.Add(new Video("Pulp Fiction"));
            items.Add(new Book("Forrest Gump"));
            consolePrinter.DisplayRent(items);
            Console.WriteLine(Environment.NewLine + "*********************");
            //Zad 4
            HotItem trendingVideo = new HotItem(new Video("The Avengers"));
            HotItem trendingBook = new HotItem(new Book("Clean Code"));
            items.Add(trendingVideo);
            items.Add(trendingBook);
            consolePrinter.DisplayRent(items);
            Console.WriteLine(Environment.NewLine + "*********************");
            /*RentableDecorator ugrađuje sučelje IRentable, a konkretna klasa HotItem prepisuje
            metode iz RentableDecoratora. Postojeći Video i Book objekti omotani su u dekorater
            koji dodaje novo ponašanje, u ovom slučaju za nove knjige i filmove.*/

            //Zad 5
            List<IRentable> flashSale = new List<IRentable>();
            foreach(IRentable item in items)
            {
                flashSale.Add(new DiscountedItem(item, 20));
            }
            consolePrinter.DisplayRent(flashSale);
        }
    }
}
