using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD1_2
{
    class ShippingService
    {
        public double PricePerKg { get; set; }

        public ShippingService(double pricePerKg)
        {
            PricePerKg = pricePerKg;
        }


        public double CalculateDeliveryPrice(IShipable package)
        {
            double deliveryPrice = package.Weight * PricePerKg;
            return Math.Round(deliveryPrice, 2);
        }
    }
}
