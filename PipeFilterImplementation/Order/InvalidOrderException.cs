using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Exceptie die aanduidt dat een order is gevraagd
    /// die niet kan worden geleverd.
    /// </summary>
    public class InvalidOrderException : Exception
    {
        /// <summary>
        /// Construeert nieuwe invalid order exceptie.
        /// </summary>
        /// <param name="exc">Foutbericht</param>
        public InvalidOrderException(string exc)
            : base(exc)
        { 
            // default implementatie
        }
    }
}
