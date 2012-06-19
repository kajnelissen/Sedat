using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class SWTest : ITest
    {
        private Random r = new Random();

        /// <summary>
        /// 
        /// </summary>
        public SWTest()
        {
        }

        /// <summary>
        /// Proces status veranderen naar software test correct of met errors.
        /// </summary>
        public override void Process()
        {
            if (input.Count > 0)
            {
                AbstractOrder o = this.input.Dequeue();

                int i = r.Next(1, 10);
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
}
