using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class InStore : Sale
    {
        public string sellerName { get; set; }

        public InStore()
        {
            interestOfService = 10;
        }

        public override void ShowSale()
        {
            Console.WriteLine($"---------- VENTA EN TIENDA -----------");
            Console.WriteLine($"--> DISPOSITIVO <--:");
            _device.ShowDevice();
            Console.WriteLine($"Nombre del comprador: {buyerName}");
            Console.WriteLine($"Nombre del vendedor: {sellerName}");
            decimal totalPrice = CalculatePriceOfDevice();
            Console.WriteLine($"Precio total de venta: {totalPrice}");
            Console.WriteLine($"\n");
        }
    }
}
