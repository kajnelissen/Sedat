using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Klasse die een GPU representeert van een bepaald type.
    /// </summary>
    public class GPU
    {
        /// <summary>
        /// Type van GPU.
        /// </summary>
        private string _type;

        /// <summary>
        /// Construeert nieuwe GPU met een bepaald type.
        /// </summary>
        /// <param name="type">Type GPU</param>
        public GPU(string type)
        {
            this._type = type;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van deze GPU.
        /// </summary>
        /// <returns>GPU tekst</returns>
        public override string ToString()
        {
            return "GPU - Type: " + this._type;
        }
    }
}
