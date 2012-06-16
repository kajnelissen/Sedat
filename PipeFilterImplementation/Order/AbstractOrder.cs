using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractOrder
    {
        /// <summary>
        /// 
        /// </summary>
        protected int _orderId;
        public int OrderId
        {
            get { return this._orderId; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected OrderStatus _status;
        public OrderStatus Status
        {
            get { return this._status; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected OrderType _type;
        public OrderType Type
        {
            get { return this._type; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        public AbstractOrder(int orderId)
        {
            this._orderId = orderId;
            this._status = OrderStatus.Start;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="os"></param>
        public AbstractOrder(int orderId, OrderStatus os)
        {
            this._orderId = orderId;
            this._status = os;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="os"></param>
        public void ChangeStatus(OrderStatus os)
        {
            this._status = os;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID: " + this._orderId + ", Type: " + this._type.ToString() + ", Status: " + this._status.ToString(); ;
        }
    }
}
