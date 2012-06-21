using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;

namespace Filters
{
    /// <summary>
    /// Abstracte class IFilter waarin filters worden uitgevoerd.
    /// In de filters worden de processtatussen gewijzigd.
    /// </summary>
    public abstract class IFilter
    {
        /// <summary>
        /// Queue van orders input
        /// </summary>
        protected Queue<AbstractOrder> input;

        /// <summary>
        /// Queue van orders output
        /// </summary>
        protected Queue<AbstractOrder> output;

        /// <summary>
        /// 
        /// </summary>
        public IFilter()
        {
            this.input = new Queue<AbstractOrder>();
            this.output = new Queue<AbstractOrder>();
        }

        /// <summary>
        /// Status van order veranderen.
        /// </summary>
        public abstract void Process();

        /// <summary>
        /// Haalt order met hoogste prioriteit uit de outputbuffer van filter.
        /// </summary>
        /// <returns>Order</returns>
        public AbstractOrder Pull()
        {
            if (output.Count != 0)
            {
                return output.Dequeue();
            }
            return null;
        }

        /// <summary>
        /// Order wordt geplaatst in inputbuffer.
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns></returns>
        public void Push(AbstractOrder order)
        {
            this.input.Enqueue(order);
        }

        /// <summary>
        /// Retourneert de status van het order met de hoogste
        /// prioriteit. Als de outputbuffer leeg is, wordt de
        /// standaardstatus geretourneerd.
        /// </summary>
        /// <returns>Status van prioriteitsorder</returns>
        public OrderStatus GetPriorityOrderStatus()
        {
            if (this.output.Count > 0)
            {
                return this.output.First().Status;
            }
            return OrderStatus.Start;
        }

        /// <summary>
        /// Aanroepen van BufferToString voor omzetten van de buffer.
        /// </summary>
        /// <returns>strings van de inputbuffer</returns>
        public List<String> InputBufferToString()
        {
            return this.BufferToString(this.input);
        }

        /// <summary>
        /// Aanroepen van BufferToString voor omzetten van de buffer.
        /// </summary>
        /// <returns>strings van de outputbuffer</returns>
        public List<String> OutputBufferToString()
        {
            return this.BufferToString(this.output);
        }

        /// <summary>
        /// Omzetten van in/outputbuffers naar strings
        /// </summary>
        /// <param name="buffer">In/outputbuffer bestaande uit abstractorders</param>
        /// <returns></returns>
        private List<String> BufferToString(Queue<AbstractOrder> buffer)
        {
            List<string> stringBuffer = new List<string>();
            foreach (AbstractOrder i in buffer)
            {
                stringBuffer.Add(i.ToString());
            }
            return stringBuffer;
        }
    }
}
