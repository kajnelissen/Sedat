using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public abstract class ISoftware
    {
        /// <summary>
        /// Versie van software
        /// </summary>
        protected string _version;

        /// <summary>
        /// Creëert nieuwe software met meegegeven versie.
        /// </summary>
        /// <param name="version">Versie</param>
        public ISoftware(string version)
        {
            this._version = version;
        }

        /// <summary>
        /// Retourneert een string weergave van deze software.
        /// </summary>
        /// <returns></returns>
        public abstract string ToString();
    }
}
