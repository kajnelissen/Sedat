using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filters
{
    /// <summary>
    /// Exceptie die aanduidt dat een order niet
    /// bestaat in filter.
    /// </summary>
    public class FilterException : Exception
    {
        /// <summary>
        /// Construeert nieuwe filterexceptie.
        /// </summary>
        /// <param name="exc">Foutbericht</param>
        public FilterException(string exc)
            : base(exc)
        {
            // default implementatie
        }
    }
}
