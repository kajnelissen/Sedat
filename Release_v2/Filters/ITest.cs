using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filters
{
    public abstract class ITest : IFilter
    {
        protected bool approval;

        //public abstract void Process(int orderId);

        /// <summary>
        /// Geeft aan of er bij het testen wel/geen fouten
        /// zijn geconstateerd.
        /// </summary>
        /// <param name="orderId">ID van order dat is gekeurd</param>
        /// <param name="approval">Goed-/afgekeurd (true/false)</param>
        public void Approve(int orderId, bool approval)
        {
            this.approval = approval;
            this.Process(orderId);
        }
    }
}
