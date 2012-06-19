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
        /// Proces status veranderen naar geïnstalleerd.
        /// </summary>
        public override void Process()
        {
            AbstractOrder o = this.input.Dequeue();
            o.ChangeStatus(OrderStatus.SoftwareInstalled);
            this.output.Enqueue(o);
        }
    }
}
