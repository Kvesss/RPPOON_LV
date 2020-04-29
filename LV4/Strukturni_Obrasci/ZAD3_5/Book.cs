using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_5
{
    class Book : IRentable
    {
        public string Title { get; private set; }
        private readonly double BaseBookPrice = 3.99;

        public Book(string title)
        {
            this.Title = title;
        }

        public string Description { get { return this.Title; } }
        public double CalculatePrice() { return BaseBookPrice; }
    }
}
