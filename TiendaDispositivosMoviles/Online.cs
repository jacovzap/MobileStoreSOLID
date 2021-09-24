using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Online : Sale
    {
        public Online()
        {
            interestOfService = 20;
        }

        public override void ShowSale()
        {
            Console.WriteLine($"---------- VENTA ONLINE -----------");
            Console.WriteLine($"-----------------> DISPOSITIVO:");
            _device.ShowDevice();
            Console.WriteLine($"----------------------------->:");
            Console.WriteLine($"Nombre del comprador: {buyerName}");
            Console.WriteLine($"Nombre del comprador: {buyerName}");
            decimal totalPrice = CalculatePriceOfDevice();
            Console.WriteLine($"Precio total de venta: {totalPrice}");
            Console.WriteLine($"\n");
        }
    }
}
