using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Representeert een laptopsysteem.
    /// </summary>
    public class Laptop : AbstractOrder
    {
        /// <summary>
        /// Construeert nieuw laptopsysteem met
        /// meegegeven order ID.
        /// </summary>
        /// <param name="orderId">Order ID</param>
        public Laptop(int orderId)
            : base(orderId)
        {
            this._type = "Laptop";
        }

        /// <summary>
        /// Construeert nieuw laptopsysteem met
        /// meegegeven order ID en status.
        /// </summary>
        /// <param name="orderId">Order ID</param>
        /// <param name="os">Beginstatus van order</param>
        public Laptop(int orderId, OrderStatus os)
            : base(orderId, os)
        {
            this._type = "Laptop";
        }
    }
}
