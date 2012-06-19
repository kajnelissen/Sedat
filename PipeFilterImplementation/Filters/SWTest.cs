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
        /// Proces status veranderen naar software test correct of met errors.
        /// </summary>
        public override void Process()
        {
            Random r = new Random();
            int i = r.Next(1, 10);
            AbstractOrder o = this.input.Dequeue();
            if (i < 9)
            {
                o.ChangeStatus(OrderStatus.SoftwareCorrect);
            }
            else
            {
                o.ChangeStatus(OrderStatus.SoftwareErrors);
            }
            this.output.Enqueue(o);
        }
    }
}
