using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Definieert de verschillende toestanden waarin een
    /// order zich kan bevinden in het productieproces.
    /// </summary>
    public enum OrderStatus
    {
        Start,              // order is binnengekomen
        Assembled,          // order is geassembleerd
        HardwareCorrect,    // hardware getest => correct
        HardwareErrors,     // hardware getest => fouten
        SoftwareInstalled,  // software geïnstalleerd
        SoftwareCorrect,    // software getest => correct
        SoftwareErrors,     // software getest => fouten  
        End                 // order afgehandeld
    }
}
