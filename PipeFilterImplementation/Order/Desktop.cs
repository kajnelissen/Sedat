using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Representeert een desktopsysteem.
    /// </summary>
    public class Desktop : AbstractOrder
    {
        /// <summary>
        /// Construeert nieuw desktopsysteem met
        /// meegegeven order ID.
        /// </summary>
        /// <param name="orderId">Order ID</param>
        public Desktop(int orderId)
            : base(orderId)
        {
            this._type = "Desktop";
        }

        /// <summary>
        /// Construeert nieuw desktopsysteem met
        /// meegegeven order ID en status.
        /// </summary>
        /// <param name="orderId">Order ID</param>
        /// <param name="os">Beginstatus van order</param>
        public Desktop(int orderId, OrderStatus os)
            : base(orderId, os)
        {
            this._type = "Desktop";
        }
    }
}
