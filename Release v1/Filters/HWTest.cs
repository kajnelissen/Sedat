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
        /// 
        /// </summary>
        public HWTest()
            : base()
        {
        }

        /// <summary>
        /// Proces status veranderen naar hardware correct/ met errors getest.
        /// </summary>
        public override void Process()
        {
            if (input.Count > 0)
            {
                AbstractOrder o = this.input.Dequeue();

                int i = r.Next(1, 10);
                if (i < 6)
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
}


