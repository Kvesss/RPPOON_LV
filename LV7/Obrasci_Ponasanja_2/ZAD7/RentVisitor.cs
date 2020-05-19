using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD7
{
    class RentVisitor : IVisitor
    {
        private double rentingPercentage;

        public RentVisitor(double rentingPercentage = 0.1)
        {
            this.rentingPercentage = rentingPercentage;
        }

        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return DVDItem.Price;
            }
            return DVDItem.Price * rentingPercentage;

        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * rentingPercentage;
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price * rentingPercentage;
        }
    }
}
