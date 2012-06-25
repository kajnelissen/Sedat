using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Klasse die een CPU representeert van een bepaald type.
    /// </summary>
    public class CPU : IComponent
    {
        /// <summary>
        /// Type van CPU.
        /// </summary>
        private string _type;

        /// <summary>
        /// Construeert nieuwe CPU met een bepaald type.
        /// </summary>
        /// <param name="type">Type CPU</param>
        public CPU(string type)
        {
            this._type = type;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van deze CPU.
        /// </summary>
        /// <returns>CPU tekst</returns>
        public override string ToString()
        {
            return "CPU - Type: " + this._type;
        }
    }
}
