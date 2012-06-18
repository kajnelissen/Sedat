using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filters
{
    abstract class IProduction : IFilter
    {
        abstract void Process();
    }
}
