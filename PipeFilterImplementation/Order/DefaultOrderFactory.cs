﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Maakt order aan voor computersysteemproductiebedrijf
    /// en kent elk order een uniek ID toe. Orders kunnen
    /// desktops of laptops zijn.
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
        /// <remarks>Merk op dat het type de waardes </remarks>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AbstractOrder CreateOrder(string type)
        {
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
    }
}
