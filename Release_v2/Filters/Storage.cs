using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class Storage : IFilter
    {
        public Storage() : base() { }

        public override void Process(int orderId)
        {
            if (!this.input.ContainsKey(orderId))
            {
                throw new FilterException("Order niet in filter.");
            }
            else
            {
                AbstractOrder order = this.input[orderId];
                this.input.Remove(orderId);
                order.ChangeStatus(OrderStatus.End);
                this.output.Add(order);
            }
        }
    }
}
