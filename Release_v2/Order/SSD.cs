using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Klasse die een SSD representeert van een bepaald type.
    /// </summary>
    public class SSD : IComponent
    {
        /// <summary>
        /// Construeert nieuwe SSD met een bepaald type.
        /// </summary>
        /// <param name="type">Type SSD</param>
        public SSD(string type) : base(type)
        {
            this._type = type;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van deze SSD.
        /// </summary>
        /// <returns>SSD tekst</returns>
        public override string ToString()
        {
            return "SSD - Type: " + this._type;
        }
    }
}
