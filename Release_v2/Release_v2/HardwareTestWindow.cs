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
    public partial class HardwareTestWindow : BaseWindow
    {
        public HardwareTestWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
        }


        /// <summary>
        /// haalt orders uit filter en voegt ze toe tot list.
        /// herlaadt formulier bij aanroep, en cleart de list dan.
        /// vult opnieuw de list met orders die getest moeten worden.
        /// </summary>
        public override void UpdateForm()
        {
            lb_HWtest.Items.Clear();

            //for (int index = 0; index < Filter.Input.Count; index++)
            //{
            // lb_HWtest.Items.Add(Filter.Input[index]).ToString();
            //}

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                lb_HWtest.Items.Add(kvp.Value.ToString());
            }
        }

        /// <summary>
        /// Order in de lb_HWtest wordt geselecteerd. de componenten worden geladen en
        /// weggeschreven naar de checkbox cbl_HWtestcomponenten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_HWtest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string obj = lb_HWtest.SelectedItem.ToString();
            string[] objects;
            objects = obj.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            /// Buitenste for wordt een foreach.
            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                if (kvp.Key == id)
                {
                    for (int index2 = 0; index2 < Filter.Input[id].Components.Count; index2++)
                    {
                        cbl_HWtestcomponenten.Items.Add(Filter.Input[id].Components[index2]);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_goedkeuring_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            // Controleren of alle componenten aangevinkt zijn.
            for (int index = 0; index < cbl_HWtestcomponenten.Items.Count; index++)
            {
                if (cbl_HWtestcomponenten.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            // Als alle componenenten aangevinkt zijn dan wordt de orderstatus gewijzigt.
            if (isChecked)
            {
                try
                {
                    string tests = lb_HWtest.SelectedItem.ToString();
                    string[] objects;
                    objects = tests.Split(',', ':');
                    int id = Convert.ToInt32(objects[1]);


                    //id meegeven en meegeven of het goedkeurd(true) of afgekeerd moet worden(false)
                    Filter.Approve(id, true);
                    cbl_HWtestcomponenten.Items.Clear();
                }
                catch (FilterException f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }

        //afkeuren van een order.
        private void btn_afgekeurd_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            if (isChecked)
            {
                try
                {
                    string tests = lb_HWtest.SelectedItem.ToString();
                    string[] objects;
                    objects = tests.Split(',', ':');
                    int id = Convert.ToInt32(objects[1]);


                    //id meegeven en meegeven of het goedkeurd(true) of afgekeerd moet worden(false)
                    Filter.Approve(id, false);
                    cbl_HWtestcomponenten.Items.Clear();
                }
                catch (FilterException f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }

    }
}