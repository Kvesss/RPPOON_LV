using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD3_5
{
    class DiscountedItem : RentableDecorator
    {
        private double discountPercentage = 0;

        public DiscountedItem(IRentable rentable, double discount): base(rentable) 
        {
            this.discountPercentage = discount;
        }

        public override double CalculatePrice()
        {
            double discountedValue = base.CalculatePrice() * (1 - discountPercentage / 100);
            return discountedValue;
        }

        public override string Description
        {
            get
            {
                return base.Description + "  NOW AT " + discountPercentage + "% OFF!";
            }
        }
    }
}
