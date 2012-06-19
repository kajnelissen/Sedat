using System;
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
    /// <summary>
    /// Simuleert productieproces van desktops en laptops.
    /// </summary>
    public class ProductionSim : ISim
    {
        //private Timer hwAssemble, hwTest, hwErrors, swInstall, swTest, swErrors, storage;

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
        public IFilter GetFilter(string filter) { return this.filters[filter]; }

        /// <summary>
        /// Pipes voor simulatie.
        /// </summary>
        private List<IPipe> pipes;

        private List<AbstractOrder> storage;
        public List<AbstractOrder> GetStorage() { return this.storage; }

        /// <summary>
        /// 
        /// </summary>
        public ProductionSim()
        {
            this.orderFac = new DefaultOrderFactory();
            this.pfFac = new PipeFilterFactory();
            this.filters = new Dictionary<string, IFilter>();
            this.pipes = new List<IPipe>();
            this.storage = new List<AbstractOrder>();
            this.rnd = new Random();
        }

        /// <summary>
        /// Simuleert proces.
        /// </summary>
        public void Simulate()
        {
            // creëer pipes en filters
            IFilter hwAssemble = new HWAssemble();
            IFilter hwTest = new HWTest();
            IFilter swInstall = new SWInstall();
            IFilter swTest = new SWTest();

            this.pipes.Add(new Pipe(ref hwAssemble, ref hwTest));
            this.pipes.Add(new Pipe(ref hwTest, ref swInstall));
            this.pipes.Add(new Pipe(ref swInstall, ref swTest));
            this.pipes.Add(new Pipe(ref hwTest, ref hwAssemble));
            this.pipes.Add(new Pipe(ref swTest, ref swInstall));

            this.filters.Add("hwAssemble", hwAssemble);
            this.filters.Add("hwTest", hwTest);
            this.filters.Add("swInstall", swInstall);
            this.filters.Add("swTest", swTest);

            // timers opzetten
            this.orderTimer = new Timer(3000);
            this.orderTimer.Enabled = true;
            this.orderTimer.Elapsed += new ElapsedEventHandler(this.NewOrder);

            this.pipeTimer = new Timer(5000);
            this.pipeTimer.Enabled = true;
            this.pipeTimer.Elapsed += new ElapsedEventHandler(this.FirePipes);

            this.filterTimer = new Timer(10000);
            this.pipeTimer.Enabled = true;
            this.pipeTimer.Elapsed += new ElapsedEventHandler(this.FireFilters);
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
        }

        /// <summary>
        /// Maakt nieuw order en pusht deze naar eerste filter in proces.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void NewOrder(object source, ElapsedEventArgs e)
        {
            int rand = this.rnd.Next(0,2);
            AbstractOrder order = ( rand == 0 ) ? 
                this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            Console.WriteLine("Nieuw order: {0}", order.ToString());
            this.filters["hwAssemble"].Push(order);
        }

        /// <summary>
        /// Plaatst orders in magazijn.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void PutInStorage(object source, ElapsedEventArgs e)
        { 
            //if ( this.filters["swTest"]. )
        }
    }
}
