using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class DevicesStore
    {
        List<MobileDevice> mobileDevicesList = new List<MobileDevice>();
        List<Sale> salesList = new List<Sale>();


        public void CreateMobileDevice()
        {
            Console.WriteLine("Que dispositivo desea registrar?");
            Console.WriteLine("1. Celular");
            Console.WriteLine("2. Tablet");
            int option = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Modelo del dispositvo: ");
            string model = Console.ReadLine();

            Console.WriteLine("Memoria RAM: ");
            decimal ram = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Modelo del procesador: ");
            string processor = Console.ReadLine();

            Console.WriteLine("Sistema Operativo: ");
            string operatingSystem = Console.ReadLine();

            Console.WriteLine("Precio: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Catnidad de unidades: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    mobileDevicesList.Add(new Phone() { model = model, ram = ram, processor = processor, operatingSystem = operatingSystem, price = price, amount = amount });
                    break;
                case 2:
                    mobileDevicesList.Add(new Tablet() { model = model, ram = ram, processor = processor, operatingSystem = operatingSystem, price = price, amount = amount });
                    break;
                default:
                    break;
            }
        }

            public MobileDevice SearchDeviceByModel()
            {
                Console.WriteLine("Dispositivo a buscar (Modelo): ");
                string model = Console.ReadLine();

                foreach (var device in mobileDevicesList)
                {
                     if (device.model == model )
                     {
                        return device;
                     }
                 }
                return null;
            }


           public void CreateASale()
           {

                Console.WriteLine("Que tipo de venta desea registrar?");
                Console.WriteLine("1. En tienda");
                Console.WriteLine("2. Online");
                int option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nombre del comprador: ");
                string buyerName = Console.ReadLine();

                MobileDevice device = SearchDeviceByModel();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Nombre del vendedor: ");
                        string sellerName = Console.ReadLine();
                        salesList.Add(new InStore() { idSale = salesList.Count, buyerName = buyerName, sellerName = sellerName, _device = device });
                        break;
                    case 2:
                        salesList.Add(new Online() { idSale = salesList.Count, buyerName = buyerName, _device = device });
                        break;
                    default:
                        break;
                }
           }


        public void ShowDevices()
        {
            Console.WriteLine("----------------------------- DISPOSITIVOS MOVILES----------------------------");
            foreach (var device in mobileDevicesList)
            {
                
                device.ShowDevice();

            }
        }

        public void ShowSales()
        {
            Console.WriteLine("----------------------------------- VENTAS-----------------------------------");
            foreach (var sale in salesList)
            {
                sale.ShowSale();
            }
        }
    }
}
