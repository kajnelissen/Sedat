using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class SWTest : ITest
    {
        /// <summary>
        /// 
        /// </summary>
        public SWTest() : base() { }

        /// <summary>
        /// Proces status veranderen naar software test correct of met errors.
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
                OrderStatus os = this.approval ? OrderStatus.SoftwareCorrect : OrderStatus.SoftwareErrors;
                order.ChangeStatus(os);
                this.output.Add(order);
            }
            //else
            //{
            //    AbstractOrder o = this.input.Dequeue();

            //    int i = r.Next(1, 10);
            //    if (i < 6)
            //    {
            //        o.ChangeStatus(OrderStatus.SoftwareCorrect);
            //    }
            //    else
            //    {
            //        o.ChangeStatus(OrderStatus.SoftwareErrors);
            //    }
            //    this.output.Enqueue(o);
            //}
        }
    }
}
