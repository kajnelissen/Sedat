using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Maakt order aan voor computersysteemproductiebedrijf en kent elk 
    /// order een uniek ID toe. Orders kunnen desktops of laptops zijn.
    /// </summary>
    public class DefaultOrderFactory : IOrderFactory
    {
        /// <summary>
        /// ID voor volgend order.
        /// </summary>
        private int _nextId;

        /// <summary>
        /// Creëert nieuwe Orderfactory 
        /// </summary>
        public DefaultOrderFactory()
        {
            this._nextId = 1;
        }

        /// <summary>
        /// Retourneert nieuw order van het meegegeven type.
        /// <remarks>Merk op dat het type de waardes 'laptop' of 'desktop' moet hebben.</remarks>
        /// </summary>
        /// <param name="type">Type van order, i.e. laptop of desktop</param>
        /// <exception cref="InvalidOrderException">InvalidOrderException</exception>
        /// <returns>Nieuw order</returns>
        public AbstractOrder CreateOrder(string type)
        {
            if (!type.Equals("desktop") && !type.Equals("laptop"))
            {
                throw new InvalidOrderException("");
            }
            AbstractOrder order = null;
            switch (type)
            {
                case "desktop":
                    order = new Desktop(this._nextId);
                    break;
                case "laptop":
                    order = new Laptop(this._nextId);
                    break;
                default:
                    break;
            }
            this._nextId++;
            return order;
        }

        /// <summary>
        /// Retourneert nieuw order van het meegegeven type.
        /// <remarks>Merk op dat het type de waardes 'laptop' of 'desktop' moet hebben.</remarks>
        /// </summary>
        /// <param name="type">Type van order, i.e. laptop of desktop</param>
        /// <param name="components">Hardware componenten (soort, type)</param>
        /// <exception cref="InvalidOrderException">InvalidOrderException</exception>
        /// <returns>Nieuw order</returns>
        public AbstractOrder CreateOrder(string type, Dictionary<string, string> components)
        {
            if (!type.Equals("desktop") && !type.Equals("laptop"))
            {
                throw new InvalidOrderException("");
            }
            AbstractOrder order = null;
            switch (type)
            {
                case "desktop":
                    order = new Desktop(this._nextId);
                    break;
                case "laptop":
                    order = new Laptop(this._nextId);
                    break;
                default:
                    break;
            }
            foreach (KeyValuePair<string, string> kvp in components)
            {
                order.AddComponent(ComponentFactory.CreateComponent(kvp.Key, kvp.Value));
            }
            this._nextId++;
            return order;
        }
    }
}
