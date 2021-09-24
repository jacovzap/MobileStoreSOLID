using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    abstract class Sale
    {
        public MobileDevice _device;
        public int idSale { get; set; }
        public string buyerName { get; set; }
        protected int interestOfService;
        public decimal CalculatePriceOfDevice()
        {
            decimal costOfSale = _device.price / interestOfService;
            return costOfSale + _device.price;
        }

        public abstract void ShowSale();
    }
}
