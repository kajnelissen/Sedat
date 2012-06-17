using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class OrderFactory : IOrderFactory
    {
        private int _nextId;

        public OrderFactory()
        {
            this._nextId = 1;
        }

        public AbstractOrder CreateOrder(string type)
        {
            AbstractOrder order = null;
            switch (t)
            {
                case "desktop":
                    order = new Desktop(this._nextId);
                    break;
                case "laptop":
                    order = new Laptop(this._nextId);
                    break;
                default:
                    break;
            }
            this._nextId++;
            return order;
        }
    }
}
