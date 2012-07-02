using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class OperatingSystem : ISoftware
    {
        public OperatingSystem(string version)
            : base(version)
        { 
            
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van dit OS.
        /// </summary>
        /// <returns>OS tekst</returns>
        public override string ToString()
        {
            return "Operating System - Versie: " + this._version;
        }
    }
}
