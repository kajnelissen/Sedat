using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// Implementeert alle basisfunctionaliteit van
    /// orders die worden geproduceerd door order factory.
    /// </summary>
    public abstract class AbstractOrder
    {
        /// <summary>
        /// Unieke identifier van order.
        /// </summary>
        protected int _orderId;
        public int OrderId
        {
            get { return this._orderId; }
        }

        /// <summary>
        /// Huidige status van order.
        /// </summary>
        protected OrderStatus _status;
        public OrderStatus Status
        {
            get { return this._status; }
        }

        /// <summary>
        /// Type van order.
        /// </summary>
        protected OrderType _type;
        public OrderType Type
        {
            get { return this._type; }
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op <c>Start</c>.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        public AbstractOrder(int orderId)
        {
            this._orderId = orderId;
            this._status = OrderStatus.Start;
        }

        /// <summary>
        /// Creëert een order met meegegeven ID en zet
        /// status op meegegeven status.
        /// </summary>
        /// <param name="orderId">Identifier voor order</param>
        /// <param name="os">Beginstatus van order</param>
        public AbstractOrder(int orderId, OrderStatus os)
        {
            this._orderId = orderId;
            this._status = os;
        }

        /// <summary>
        /// Verandert huidige status van order naar
        /// meegegeven status.
        /// </summary>
        /// <param name="os">Nieuwe status</param>
        public void ChangeStatus(OrderStatus os)
        {
            this._status = os;
        }

        /// <summary>
        /// Retourneert een tekstuele weergave van order waarin 
        /// het ID, type en status worden weergegeven.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " + this._orderId + ", Type: " + this._type.ToString() + ", Status: " + this._status.ToString(); ;
        }
    }
}
