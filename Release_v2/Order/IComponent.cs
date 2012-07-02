using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Definieert een interface voor hardwarecomponenten.
    /// </summary>
    public abstract class IComponent
    {
        /// <summary>
        /// Type van component
        /// </summary>
        protected string _type;

        /// <summary>
        /// Creëert nieuwe component met meegegeven type
        /// </summary>
        /// <param name="type">Type</param>
        public IComponent(string type)
        { 
            this._type = type;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van deze component.
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
