using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    public delegate void Notifier();

    /// <summary>
    /// Abstracte class IFilter waarin filters worden uitgevoerd.
    /// In de filters worden de processtatussen gewijzigd.
    /// </summary>
    public abstract class IFilter
    {
        /// <summary>
        /// Getriggerde events
        /// </summary>
        public event Notifier OnPush, OnProcess;

        /// <summary>
        /// Queue van orders input
        /// </summary>
        protected Dictionary<int, AbstractOrder> input;
        public Dictionary<int, AbstractOrder> Input { get { return this.input; } }

        /// <summary>
        /// Queue van orders output
        /// </summary>
        protected List<AbstractOrder> output;
        public List<AbstractOrder> Output { get { return this.output; } }

        /// <summary>
        /// 
        /// </summary>
        public IFilter()
        {
            this.input = new Dictionary<int, AbstractOrder>();
            this.output = new List<AbstractOrder>();
        }

        /// <summary>
        /// Status van order veranderen.
        /// </summary>
        public abstract void Process(int orderId);

        /// <summary>
        /// Haalt order met hoogste prioriteit uit de outputbuffer van filter.
        /// </summary>
        /// <returns>Order</returns>
        public AbstractOrder Pull(List<OrderStatus> withStatus)
        {
            AbstractOrder order = null;
            if (this.output.Count != 0)
            {
                if (withStatus == null)
                {
                    order = this.output.First();
                    this.output.RemoveAt(0);
                }
                else
                {
                    try
                    {
                        // zoek naar eerste order met een juiste status
                        order = this.output.First(o => withStatus.Contains(o.Status));
                        this.output.Remove(order);
                    }
                    catch (InvalidOperationException e)
                    {
                        // geen order met juiste status in filter
                        order = null;
                    }
                }
            }
            return order;
        }

        /// <summary>
        /// Order wordt geplaatst in inputbuffer.
        /// </summary>
        /// <param name="order">Order</param>
        public void Push(AbstractOrder order)
        {
            if (order != null)
            {
                this.input.Add(order.OrderId, order);
                this.OnPush();
            }
        }

        public virtual void Approve(int orderId, bool approval) { }
    }
}
