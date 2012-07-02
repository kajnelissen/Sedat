using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class OfficeSuite : ISoftware
    {
        public OfficeSuite(string version)
            : base(version)
        { 
            
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van dit kantoorpakket.
        /// </summary>
        /// <returns>Office suite tekst</returns>
        public override string ToString()
        {
            return "Office Suite - Versie: " + this._version;
        }
    }
}
