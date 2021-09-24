using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Tablet : MobileDevice
    {
        public override void ShowDevice()
        {
            Console.WriteLine($"\n");
            Console.WriteLine($"---------- TABLET -----------");
            Console.WriteLine($"Modelo del dispositvo: {model}");
            Console.WriteLine($"Modelo del procesador: {processor}");
            Console.WriteLine($"Memoria RAM: {ram}");
            Console.WriteLine($"Sistema Operativo: {operatingSystem}");
            Console.WriteLine($"Precio: {price}");
            Console.WriteLine($"Unidades: {amount}");
            
        }
    }
}
