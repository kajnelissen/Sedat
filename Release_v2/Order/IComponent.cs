using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Definieert een interface voor hardwarecomponenten.
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Retourneert een tekstuele weergave van deze component.
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
