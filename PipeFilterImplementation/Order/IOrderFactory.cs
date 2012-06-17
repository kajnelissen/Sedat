using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    interface IOrderFactory
    {
        AbstractOrder CreateOrder(string type);
    }
}
