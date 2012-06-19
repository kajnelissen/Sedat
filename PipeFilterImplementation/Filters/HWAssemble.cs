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
        /// Proces status veranderen naar geassembleerd.
        /// </summary>
        public override void Process()
        {
            AbstractOrder o = this.input.Dequeue();
            o.ChangeStatus(OrderStatus.Assembled);
            this.output.Enqueue(o);
        }
    }
}
