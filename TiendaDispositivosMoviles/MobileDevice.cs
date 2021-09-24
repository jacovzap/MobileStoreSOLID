using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    abstract class MobileDevice
    {
   
        public string model { get; set; }
        public decimal ram  { get; set; }
        public string processor { get; set; }
        public string operatingSystem { get; set; }
        public decimal price { get; set; }
        public int amount { get; set; }

        public abstract void ShowDevice();
    }
}
