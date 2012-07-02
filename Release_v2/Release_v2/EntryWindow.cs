using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Filters;
using Pipes;
using PFFactory;
using Order;
using System.Timers;

namespace Release_v2
{
    public partial class EntryWindow : Form
    {
        private bool _running;

        /// <summary>
        /// Factory om pipes en filters mee te creëren.
        /// </summary>
        private IPipeFilterFactory _pfFac;

        /// <summary>
        /// Filters
        /// </summary>
        private Dictionary<string, IFilter> _filters;

        /// <summary>
        /// Pipes
        /// </summary>
        private List<IPipe> _pipes;

        public EntryWindow()
        {
            InitializeComponent();
            this._pfFac = new PipeFilterFactory();
            this._running = false;
            this._filters = new Dictionary<string, IFilter>();
            this._pipes = new List<IPipe>();
        }

        public EntryWindow(IPipeFilterFactory fac)
        {
            InitializeComponent();
            this._pfFac = fac;
            this._running = false;
            this._filters = new Dictionary<string, IFilter>();
            this._pipes = new List<IPipe>();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!this._running)
            {
                #region Filters initialiseren

                // initialiseer pipeline
                IFilter hwAssemble = this._pfFac.CreateFilter("hwAssemble");
                IFilter hwTest = this._pfFac.CreateFilter("hwTest");
                IFilter swInstall = this._pfFac.CreateFilter("swInstall");
                IFilter swTest = this._pfFac.CreateFilter("swTest");
                IFilter storage = this._pfFac.CreateFilter("storage");

                #endregion

                #region Pipes initialiseren

                IPipe pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref hwAssemble, ref hwTest);
                this._pipes.Add(pipe);               

                pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref hwTest, ref swInstall);
                pipe.AddFireTrigger(OrderStatus.HardwareCorrect);
                this._pipes.Add(pipe);

                pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref swInstall, ref swTest);
                this._pipes.Add(pipe);

                pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref hwTest, ref hwAssemble);
                pipe.AddFireTrigger(OrderStatus.HardwareErrors);
                this._pipes.Add(pipe);

                pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref swTest, ref swInstall);
                pipe.AddFireTrigger(OrderStatus.SoftwareErrors);
                this._pipes.Add(pipe);

                pipe = this._pfFac.CreatePipe();
                pipe.Connect(ref swTest, ref storage);
                pipe.AddFireTrigger(OrderStatus.SoftwareCorrect);
                this._pipes.Add(pipe);

                //this._pipes.Add(new Pipe(ref hwAssemble, ref hwTest));
                //this._pipes.Add(new Pipe(ref hwTest, ref swInstall, new List<OrderStatus> { OrderStatus.HardwareCorrect }));
                //this._pipes.Add(new Pipe(ref swInstall, ref swTest));
                //this._pipes.Add(new Pipe(ref hwTest, ref hwAssemble, new List<OrderStatus> { OrderStatus.HardwareErrors }));
                //this._pipes.Add(new Pipe(ref swTest, ref swInstall, new List<OrderStatus> { OrderStatus.SoftwareErrors }));
                //this._pipes.Add(new Pipe(ref swTest, ref storage, new List<OrderStatus> { OrderStatus.SoftwareCorrect }));

                #endregion

                // open formulieren
                OrderInputWindow oiw = new OrderInputWindow(ref hwAssemble); oiw.Show();
                AssemblyWindow ass = new AssemblyWindow(ref hwAssemble); ass.Show();
                HardwareTestWindow htw = new HardwareTestWindow(ref hwTest); htw.Show();
                SoftwareInstallWindow siw = new SoftwareInstallWindow(ref swInstall); siw.Show();
                SoftwareTestWindow stw = new SoftwareTestWindow(ref swTest); stw.Show();
                StorageWindow sw = new StorageWindow(ref storage); sw.Show();

                this._filters.Add("hwAssemble", hwAssemble);
                this._filters.Add("hwTest", hwTest);
                this._filters.Add("swInstall", swInstall);
                this._filters.Add("swTest", swTest);
                this._filters.Add("storage", storage);

                this._running = true;
            }
        }

        /// <summary>
        /// Vuur pipes
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void FirePipes(object source, ElapsedEventArgs e)
        {
            foreach (IPipe p in this._pipes)
            {
                p.Transport();
            }
        }
    }
}
