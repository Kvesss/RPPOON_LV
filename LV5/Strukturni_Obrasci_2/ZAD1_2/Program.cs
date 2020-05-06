using System;

namespace ZAD1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad 1
            Console.WriteLine("Zadatak 1.  ********************");
            Box boxingBox = new Box("Boxing box", 2);
            boxingBox.Add(new Product("gloves", 100, 0.4));
            boxingBox.Add(new Product("bandage", 20, 0.08));
            boxingBox.Add(new Product("shoes", 120, 0.6));
            Console.WriteLine(boxingBox.Description());
            Console.WriteLine("Price: " + boxingBox.Price);

            //Zad 2
            Console.WriteLine("Zadatak 2.  ********************");
            ShippingService shippingService = new ShippingService(0.5);
            double deliveryPrice = shippingService.CalculateDeliveryPrice(boxingBox);
            Console.WriteLine("Delivery price: " + deliveryPrice);
            shippingService.PricePerKg = 1;
            deliveryPrice = shippingService.CalculateDeliveryPrice(boxingBox);
            Console.WriteLine("Delivery price: " + deliveryPrice);
        }
    }
}
