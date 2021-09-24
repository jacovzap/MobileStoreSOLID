using System;
using Store;

namespace TiendaDispositivosMoviles
{
    class Program
    {
        static void Main(string[] args)
        {
            DevicesStore devBolivia = new DevicesStore();
            devBolivia.CreateMobileDevice();
            devBolivia.CreateMobileDevice();
            devBolivia.CreateMobileDevice();

            devBolivia.CreateASale();
            devBolivia.CreateASale();

            devBolivia.ShowDevices();
            devBolivia.ShowSales();

        }
    }
}
