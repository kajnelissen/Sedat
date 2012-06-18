using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Order;

namespace Pipes
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class IPipe
    {
        /// <summary>
        /// Filter waar deze pipe data
        /// vandaan haalt.
        /// </summary>
        private IFilter from;

        /// <summary>
        /// Filter waar deze pipe data
        /// naartoe transporteert.
        /// </summary>
        private IFilter to;

        /// <summary>
        /// Construeert nieuwe pipe zonder
        /// verbindingen met filters.
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
        public IPipe(IFilter from, IFilter to)
        { 
            
        }

        public void Connect(IFilter from, IFilter to)
        { 
            
        }

        public void SetStartPoint(IFilter from)
        { 
            
        }

        public void SetEndPoint(IFilter to)
        { 
            
        }

        public void Transport()
        { 
            
        }
    }
}
