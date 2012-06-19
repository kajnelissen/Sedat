using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class HWTest : ITest
    {
        private Random r = new Random();

        /// <summary>
        /// Proces status veranderen naar hardware correct/ met errors getest.
        /// </summary>
        public override void Process()
        {
            int i = r.Next(1, 10);
            AbstractOrder o = this.input.Dequeue();
            if (i < 9)
            {
                o.ChangeStatus(OrderStatus.HardwareCorrect);
            }
            else
            {
                o.ChangeStatus(OrderStatus.HardwareErrors);
            }
            this.output.Enqueue(o);
        }
    }
}
