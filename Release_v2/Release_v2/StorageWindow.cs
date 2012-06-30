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

        public StorageWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
            orders = new List<AbstractOrder>();
        }

        //public override void UpdateForm()
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// controleren of er nieuwe orders met status END zijn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            //todo: alles orders ophalen met status END
                        

            //alle orders worden in de listbox gezet
            int index = 0;
            while (orders.Count > index)
            {
                lb_orders.Items.Add(orders[index]);
                index++;
            }
        }
    }
}
