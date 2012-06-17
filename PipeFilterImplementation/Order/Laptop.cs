using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class Laptop : AbstractOrder
    {
        public Laptop(int orderId)
            : base(orderId)
        {
            this._type = "Laptop";
        }

        public Laptop(int orderId, OrderStatus os)
            : base(orderId, os)
        {
            this._type = "Laptop";
        }
    }
}
