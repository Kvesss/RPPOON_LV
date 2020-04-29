using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZAD3_5
{
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(Math.Round(items.Sum(r => r.CalculatePrice()),2));
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }

        public void DisplayRent(List<IRentable> items)
        {
            Console.WriteLine("Rented items:\n");
            DisplayItems(items);
            Console.Write(Environment.NewLine);
            Console.Write("Total price:  ");
            PrintTotalPrice(items);
        }
    }
}
