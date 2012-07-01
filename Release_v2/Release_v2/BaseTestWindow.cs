using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Filters;

namespace Release_v2
{
    public partial class BaseTestWindow : Form
    {
        /// <summary>
        /// Filter waarop formulier is geabonneerd.
        /// </summary>
        private ITest _filter;
        public ITest Filter { get { return this._filter; } }

        /// <summary>
        /// Creëert nieuw basisformulier zonder zich te abonneren op een filter.
        /// </summary>
        public BaseTestWindow()
            : base()
        {
            this._filter = null;
        }

        /// <summary>
        /// Creëert nieuw basisformulier dat geabonneerd is op
        /// de meegegeven filter.
        /// </summary>
        /// <param name="filter">Filter</param>
        public BaseTestWindow(ref ITest filter)
            : base()
        {
            filter.OnPush += this.UpdateForm;
            filter.OnProcess += this.UpdateForm;
            this._filter = filter;
        }

        /// <summary>
        /// Abonneert formulier op meegegeven filter.
        /// </summary>
        /// <param name="filter">Filter</param>
        public void ObserveFilter(ref ITest filter)
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
        public virtual void UpdateForm() { }
    }
}