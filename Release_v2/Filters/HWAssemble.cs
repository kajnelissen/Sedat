using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;
using Filters;

namespace Filters
{
    /// <summary>
    /// HWAssemble object waarin de orderstatus wordt veranderd naar geassembleerd.
    /// </summary>
    public class HWAssemble : IProduction
    {
        /// <summary>
        /// 
        /// </summary>
        public HWAssemble() : base() { }

        /// <summary>
        /// Proces status veranderen naar geassembleerd.
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
                order.ChangeStatus(OrderStatus.Assembled);
                this.output.Add(order);
            }
            //if (input.Count > 0)
            //{
            //    AbstractOrder o = this.input.Dequeue();
            //    o.ChangeStatus(OrderStatus.Assembled);
            //    this.output.Enqueue(o);
            //}        
        }
    }
}
