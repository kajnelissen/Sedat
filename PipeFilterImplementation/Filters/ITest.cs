using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filters
{
    abstract class ITest : IFilter
    {
        abstract void Process();
    }
}
