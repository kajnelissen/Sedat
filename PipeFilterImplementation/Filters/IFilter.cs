using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class IFilter
    {
        abstract void Process();

        AbstractOrder Pull();

        void Push(AbstractOrder order);
    }
}
