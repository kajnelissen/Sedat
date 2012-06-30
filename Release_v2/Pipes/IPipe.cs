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
        /// Als deze lijst leeg is, zijn alle statussen valide.
        /// </summary>
        protected List<OrderStatus> _fireTriggers;

        /// <summary>
        /// Construeert nieuwe pipe zonder verbindingen met filters.
        /// </summary>
        public IPipe()
        {
            this._from = null;
            this._to = null;
            this._fireTriggers = null;
        }

        /// <summary>
        /// Construeert een nieuwe pipe en laat deze de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        public IPipe(ref IFilter from, ref IFilter to)
        {
            this.Connect(ref from, ref to);
            this._fireTriggers = null;
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
        /// <param name="to">Filter waar data naartoe gaat</param>
        public void SetEndPoint(ref IFilter to)
        {
            this._to = to;
        }

        /// <summary>
        /// Voegt meegegeven orderstatus toe aan triggerlijst.
        /// </summary>
        /// <param name="os">Orderstatus</param>
        public void AddFireTrigger(OrderStatus os)
        {
            if (this._fireTriggers == null)
            {
                this._fireTriggers = new List<OrderStatus>();
            }
            this._fireTriggers.Add(os);
        }

        /// <summary>
        /// Haalt order met hoogste prioriteit uit bronfilter en
        /// verplaatst deze naar verbonden filter.
        /// </summary>
        public void Transport()
        {
            AbstractOrder order;
            while ( (order = this._from.Pull(this._fireTriggers)) != null )
            {
                this._to.Push(order);
            }
        }
    }
}
