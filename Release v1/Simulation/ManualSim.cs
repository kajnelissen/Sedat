using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Order;
using Filters;
using Pipes;
using PFFactory;

namespace Simulation
{
    /// <summary>
    /// Handmatige simulatie die vooral als een façade boven
    /// de applicatie hangt.
    /// </summary>
    public class ManualSim : ISim
    {
        /// <summary>
        /// Event dat wordt getriggerd zodra simulatie een stap verder is.
        /// </summary>
        public event Notifier Notify;

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
        //private List<IPipe> pipes;
        private Dictionary<string, IPipe> pipes;

        /// <summary>
        /// 
        /// </summary>
        public ManualSim()
        {
            this.orderFac = new DefaultOrderFactory();
            this.pfFac = new PipeFilterFactory();
            this.filters = new Dictionary<string, IFilter>();
            this.pipes = new Dictionary<string, IPipe>();
        }

        /// <summary>
        /// 
        /// </summary>
        public ManualSim(IPipeFilterFactory pf, IOrderFactory of)
        {
            this.orderFac = of;
            this.pfFac = pf;
            this.filters = new Dictionary<string, IFilter>();
            this.pipes = new Dictionary<string, IPipe>();
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

            this.pipes.Add("hwahwt", new Pipe(ref hwAssemble, ref hwTest));
            this.pipes.Add("hwtswi", new Pipe(ref hwTest, ref swInstall, new List<OrderStatus> { OrderStatus.HardwareCorrect }));
            this.pipes.Add("swiswt", new Pipe(ref swInstall, ref swTest));
            this.pipes.Add("hwthwa", new Pipe(ref hwTest, ref hwAssemble, new List<OrderStatus> { OrderStatus.HardwareErrors }));
            this.pipes.Add("swtswi", new Pipe(ref swTest, ref swInstall, new List<OrderStatus> { OrderStatus.SoftwareErrors }));
            this.pipes.Add("swtsto", new Pipe(ref swTest, ref storage, new List<OrderStatus> { OrderStatus.SoftwareCorrect }));

            this.filters.Add("hwAssemble", hwAssemble);
            this.filters.Add("hwTest", hwTest);
            this.filters.Add("swInstall", swInstall);
            this.filters.Add("swTest", swTest);
            this.filters.Add("storage", storage);

            #endregion
        }

        /// <summary>
        /// Vuur pipes
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void FirePipes()
        {
            foreach (KeyValuePair<string, IPipe> kvp in this.pipes)
            {
                kvp.Value.Transport();
            }
            this.Notify();
        }

        /// <summary>
        /// Vuur filters
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void FireFilters()
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
        public void NewOrder()
        {
            //int rand = this.rnd.Next(0, 2);
            //AbstractOrder order = (rand == 0) ?
            //    this.orderFac.CreateOrder("desktop") : this.orderFac.CreateOrder("laptop");
            //Console.WriteLine("Nieuw order: {0}", order.ToString());
            //this.filters["hwAssemble"].Push(order);
        }
    }
}
