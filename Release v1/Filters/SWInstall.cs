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
        public SWInstall() : base()
        {
        }

        /// <summary>
        /// Proces status veranderen naar geïnstalleerd.
        /// </summary>
        public override void Process()
        {
            if (input.Count > 0)
            {
                AbstractOrder o = this.input.Dequeue();
                o.ChangeStatus(OrderStatus.SoftwareInstalled);
                this.output.Enqueue(o);
            }
        }
    }
}
