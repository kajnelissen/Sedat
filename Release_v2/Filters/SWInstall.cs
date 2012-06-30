using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class SWInstall : IProduction
    {
        /// <summary>
        /// 
        /// </summary>
        public SWInstall() : base() { }

        /// <summary>
        /// Proces status veranderen naar geïnstalleerd.
        /// </summary>
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
                order.ChangeStatus(OrderStatus.SoftwareInstalled);
                this.output.Add(order);
            }
            //if (input.Count > 0)
            //{
            //    AbstractOrder o = this.input.Dequeue();
            //    o.ChangeStatus(OrderStatus.SoftwareInstalled);
            //    this.output.Enqueue(o);
            //}
        }
    }
}
