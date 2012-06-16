using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class Desktop : AbstractOrder
    {
        public Desktop(int orderId)
            : base(orderId)
        {
            this._type = OrderType.Desktop;
        }

        public Desktop(int orderId, OrderStatus os)
            : base(orderId, os)
        {
            this._type = OrderType.Desktop;
        }
    }
}
