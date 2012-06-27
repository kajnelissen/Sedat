using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Filters;

namespace Release_v2
{
    public abstract partial class BaseWindow : Form
    {
        /// <summary>
        /// Filter waarop formulier is geabonneerd.
        /// </summary>
        protected IFilter _filter;

        /// <summary>
        /// Creëert nieuw basisformulier dat geabonneerd is op
        /// de meegegeven filter.
        /// </summary>
        /// <param name="filter">Filter</param>
        public BaseWindow(ref IFilter filter) : base()
        {
            this._filter = filter;
            this._filter.OnPush += this.Update;
            this._filter.OnProcess += this.Update;
        }

        /// <summary>
        /// Abstracte methode welke alle logica implementeert
        /// die te maken heeft met het verversen van de informatie
        /// op het formulier.
        /// </summary>
        public abstract void Update();
    }
}
