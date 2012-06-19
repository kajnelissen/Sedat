using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Definieert een interface voor het aanmaken van
    /// nieuwe orders.
    /// </summary>
    public interface IOrderFactory
    {
        /// <summary>
        /// Retourneert een order van het meegegeven type.
        /// </summary>
        /// <param name="type">Het type order</param>
        /// <returns>Order</returns>
        AbstractOrder CreateOrder(string type);
    }
}
