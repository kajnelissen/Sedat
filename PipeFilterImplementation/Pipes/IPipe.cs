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
        private IFilter from;

        /// <summary>
        /// Filter waar deze pipe data naartoe transporteert.
        /// </summary>
        private IFilter to;

        /// <summary>
        /// Construeert nieuwe pipe zonder verbindingen met filters.
        /// </summary>
        public IPipe()
        {
            this.from = null;
            this.to = null;
        }

        /// <summary>
        /// Construeert een nieuwe pipe en laat deze
        /// de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        public IPipe(ref IFilter from, ref IFilter to)
        {
            this.Connect(ref from, ref to);
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
            this.from = from;
        }

        /// <summary>
        /// Wijzigt de filter waar deze pipe data naartoe stuurt.
        /// </summary>
        /// <param name="to"></param>
        public void SetEndPoint(ref IFilter to)
        {
            this.to = to;
        }

        /// <summary>
        /// Haalt order met hoogste prioriteit uit bronfilter en
        /// verplaatst deze naar verbonden filter.
        /// </summary>
        public void Transport()
        {
            AbstractOrder order = this.from.Pull();
            if (order != null)
            {
                this.to.Push(order);
            }
        }
    }
}
