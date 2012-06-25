using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public class Storage : IFilter
    {
        public Storage() : base()
        {
        }

        public override void Process()
        {
            if (input.Count > 0)
            {
                AbstractOrder o = this.input.Dequeue();
                o.ChangeStatus(OrderStatus.End);
                this.output.Enqueue(o);
            }
        }
    }
}
