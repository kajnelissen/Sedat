using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Order;

namespace Pipes
{
    /// <summary>
    /// Een pipe die twee filters met elkaar verbindt zodat er
    /// dataoverdracht kan plaatsvinden tussen deze filters.
    /// </summary>
    public class Pipe : IPipe
    {
        /// <summary>
        /// Construeert nieuwe pipe zonder verbindingen met filters.
        /// </summary>
        public Pipe() : base() {}

        /// <summary>
        /// Construeert een nieuwe pipe en laat deze
        /// de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        public Pipe(ref IFilter from, ref IFilter to) : base(ref from, ref to) {}

        /// <summary>
        /// Construeert een nieuwe pipe die orders verplaatst als ze een van de
        /// meegegeven statussen hebben, en laat deze de meegegeven filters verbinden.
        /// </summary>
        /// <param name="from">Filter waar data vandaan komt</param>
        /// <param name="to">Filter waar data naartoe gaat</param>
        /// <param name="fireTriggers">Lijst van statussen waarop deze pipe reageert</param>
        public Pipe(ref IFilter from, ref IFilter to, List<OrderStatus> fireTriggers) : base(ref from, ref to, fireTriggers) {}
    }
}
