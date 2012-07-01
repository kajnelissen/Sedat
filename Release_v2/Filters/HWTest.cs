using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class HWTest : ITest
    {
        /// <summary>
        /// 
        /// </summary>
        public HWTest() : base() { }

        /// <summary>
        /// Proces status veranderen naar hardware correct/ met errors getest.
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
                OrderStatus os = this.approval ? OrderStatus.HardwareCorrect : OrderStatus.HardwareErrors;
                order.ChangeStatus(os);
                this.output.Add(order);
                this.RaiseProcess();
            }
        }
    }
}


