using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Order;

namespace Pipes
{
    /// <summary>
    /// Abstracte klasse die de basisfunctionaliteit van een pipe 
    /// implementeert. Een pipe is hierbij een verbinding tussen 
    /// twee filters waartussen dataoverdracht plaatsvindt.
    /// </summary>
    public abstract class IPipe
    {
        /// <summary>
        /// Filter waar deze pipe data vandaan haalt.
        /// </summary>
        protected IFilter _from;

        /// <summary>
        /// Filter waar deze pipe data naartoe transporteert.
        /// </summary>
        protected IFilter _to;

        /// <summary>
        /// Lijst van orderstatussen waarop deze pipe kan vuren.
        /// </summary>
        protected List<OrderStatus> _fireTriggers;

        /// <summary>
        /// Construeert nieuwe pipe zonder verbindingen met filters.
        /// </summary>
        public IPipe()
        {
            this._from = null;
            this._to = null;
            this._fireTriggers = new List<OrderStatus>();
        }

        /// <summary>
        /// Construeert een nieuwe pipe en laat deze de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        public IPipe(ref IFilter from, ref IFilter to)
        {
            this.Connect(ref from, ref to);
            this._fireTriggers = new List<OrderStatus>();
        }

        /// <summary>
        /// Construeert een nieuwe pipe die orders verplaatst als ze een van de
        /// meegegeven statussen hebben, en laat deze de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        /// <param name="fireTriggers">Lijst van statussen waarop deze pipe reageert</param>
        public IPipe(ref IFilter from, ref IFilter to, List<OrderStatus> fireTriggers)
        {
            this.Connect(ref from, ref to);
            this._fireTriggers = fireTriggers;
        }

        /// <summary>
        /// Verbindt twee filters met elkaar en plaatst
        /// ze aan beide uiteinden van deze pipe.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        public void Connect(ref IFilter from, ref IFilter to)
        {
            this.SetStartPoint(ref from);
            this.SetEndPoint(ref to);
        }

        /// <summary>
        /// Wijzigt de filter waar deze pipe data vandaan haalt.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        public void SetStartPoint(ref IFilter from)
        {
            this._from = from;
        }

        /// <summary>
        /// Wijzigt de filter waar deze pipe data naartoe stuurt.
        /// </summary>
        /// <param name="to"></param>
        public void SetEndPoint(ref IFilter to)
        {
            this._to = to;
        }

        /// <summary>
        /// Haalt order met hoogste prioriteit uit bronfilter en
        /// verplaatst deze naar verbonden filter.
        /// </summary>
        public void Transport()
        {
            if (this.CanFire())
            {
                AbstractOrder order = this._from.Pull();
                if (order != null)
                {
                    this._to.Push(order);
                }
            }
        }

        /// <summary>
        /// Retourneert of deze pipe data kan transporteren
        /// onder de huidige condities.
        /// </summary>
        /// <returns>True indien mogelijk, anders false</returns>
        public bool CanFire()
        {
            if (this._fireTriggers.Count == 0)
            {
                return true;
            }
            OrderStatus os = this._from.GetPriorityOrderStatus();
            if (os == OrderStatus.Start)
            {
                return true;
            }
            else
            {
                return this._fireTriggers.Contains(os);
            }
        }
    }
}
