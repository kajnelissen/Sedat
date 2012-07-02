using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Filters;
using Order;

namespace Release_v2
{
    public partial class StorageWindow : BaseWindow
    {
        /// <summary>
        /// alle orders in deze filter
        /// </summary>
        private List<AbstractOrder> orders;

        /// <summary>
        /// hier wordt de lijst uitgehaald
        /// </summary>
        private IFilter storage;

        public StorageWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
            orders = new List<AbstractOrder>();
            storage = new Storage();
        }

        public override void UpdateForm()
        {
            
            lb_orders.Items.Clear();

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                lb_orders.Items.Add(kvp.Value.ToString());
            }
        }

        
    }
}
