﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Order;
using Filters;
using Pipes;
using PFFactory;

namespace Simulation
{
    public delegate void Notifier();

    /// <summary>
    /// Simuleert automatisch het productieproces van desktops en laptops.
    /// </summary>
    public class AutoSim : ISim
    {
        /// <summary>
        /// Event dat wordt getriggerd zodra simulatie een stap verder is.
        /// </summary>
        public event Notifier Notify;

        /// <summary>
        /// Timers voor het vuren van pipes en filters.
        /// </summary>
        private Timer orderTimer, pipeTimer, filterTimer;

        private Random rnd;

        /// <summary>
        /// 
        /// </summary>
        private IOrderFactory orderFac;

        /// <summary>
        /// 
        /// </summary>
        private IPipeFilterFactory pfFac;

        /// <summary>
        /// Filters voor simulatie.
        /// </summary>
        private Dictionary<string, IFilter> filters;
        public List<string> GetFilterInput(string filter) { return this.filters[filter].InputBufferToString(); }
        public List<string> GetFilterOutput(string filter) { return this.filters[filter].OutputBufferToString(); }

        /// <summary>
        /// Pipes voor simulatie.
        /// </summary>
        private List<IPipe> pipes;

        /// <summary>
        /// 
        /// </summary>
        public AutoSim()
        {
            this.orderFac = new DefaultOrderFactory();
            this.pfFac = new PipeFilterFactory();
            this.filters = new Dictionary<string, IFilter>();
            this.pipes = new List<IPipe>();
            this.rnd = new Random();
        }

        /// <summary>
        /// 
        /// </summary>
        public AutoSim(IPipeFilterFactory pf, IOrderFactory of)
        {
            this.orderFac = of;
            this.pfFac = pf;
            this.filters = new Dictionary<string, IFilter>();
            this.pipes = new List<IPipe>();
            this.rnd = new Random();
        }

        /// <summary>
        /// Simuleert proces.
        /// </summary>
        public void Simulate()
        {
            #region Creëren van pipes en filters

            IFilter hwAssemble = this.pfFac.CreateFilter("HWASSEMBLE");
            IFilter hwTest = this.pfFac.CreateFilter("HWTEST");
            IFilter swInstall = this.pfFac.CreateFilter("SWINSTALL");
            IFilter swTest = this.pfFac.CreateFilter("SWTEST");
            IFilter storage = this.pfFac.CreateFilter("STORAGE");

            this.pipes.Add(new Pipe(ref hwAssemble, ref hwTest));
            this.pipes.Add(new Pipe(ref hwTest, ref swInstall, new List<OrderStatus> { OrderStatus.HardwareCorrect }));
            this.pipes.Add(new Pipe(ref swInstall, ref swTest));
            this.pipes.Add(new Pipe(ref hwTest, ref hwAssemble, new List<OrderStatus> { OrderStatus.HardwareErrors }));
            this.pipes.Add(new Pipe(ref swTest, ref swInstall, new List<OrderStatus> { OrderStatus.SoftwareErrors }));
            this.pipes.Add(new Pipe(ref swTest, ref storage, new List<OrderStatus> { OrderStatus.SoftwareCorrect }));

            this.filters.Add("hwAssemble", hwAssemble);
            this.filters.Add("hwTest", hwTest);
            this.filters.Add("swInstall", swInstall);
            this.filters.Add("swTest", swTest);
            this.filters.Add("storage", storage);

            #endregion

            #region Timers opzetten

            this.orderTimer = new Timer(2000);
            this.orderTimer.Enabled = true;
            this.orderTimer.Elapsed += new ElapsedEventHandler(this.NewOrder);

            this.pipeTimer = new Timer(3000);
            this.pipeTimer.Enabled = true;
            this.pipeTimer.Elapsed += new ElapsedEventHandler(this.FirePipes);

            this.filterTimer = new Timer(4000);
            this.pipeTimer.Enabled = true;
            this.pipeTimer.Elapsed += new ElapsedEventHandler(this.FireFilters);

            #endregion
        }

        /// <summary>
        /// Vuur pipes
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void FirePipes(object source, ElapsedEventArgs e)
        {
            foreach (IPipe p in this.pipes)
            {
                p.Transport();
            }
            this.Notify();
        }

        /// <summary>
        /// Vuur filters
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void FireFilters(object source, ElapsedEventArgs e)
        {
            foreach (KeyValuePair<string, IFilter> kvp in this.filters)
            {
                kvp.Value.Process();
            }
            this.Notify();
        }

        /// <summary>
        /// Maakt nieuw order en pusht deze naar eerste filter in proces.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void NewOrder(object source, ElapsedEventArgs e)
        {
            int rand = this.rnd.Next(0, 2);
            AbstractOrder order = (rand == 0) ?
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            Console.WriteLine("Nieuw order: {0}", order.ToString());
            this.filters["hwAssemble"].Push(order);
        }
    }
}
