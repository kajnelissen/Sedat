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
    public partial class SoftwareTestWindow : BaseWindow
    {
        public SoftwareTestWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
        }

        /// <summary>
        ///
        /// </summary>
        public override void UpdateForm()
        {
            lb_SWTest.Items.Clear();

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                lb_SWTest.Items.Add(kvp.Value.ToString());
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_SWTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string obj = lb_SWTest.SelectedItem.ToString();
            string[] objects;
            objects = obj.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);


            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                if (kvp.Key == id)
                {
                    for (int index2 = 0; index2 < Filter.Input[id].Components.Count; index2++)
                    {
                        cbl_SWtestcomponenten.Items.Add(Filter.Input[id].Components[index2]);
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SWgoedkeuring_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            // Controleren of alle componenten aangevinkt zijn.
            for (int index = 0; index < cbl_SWtestcomponenten.Items.Count; index++)
            {
                if (cbl_SWtestcomponenten.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            // Als alle componenenten aangevinkt zijn dan wordt de orderstatus gewijzigt.
            if (isChecked)
            {

                try
                {
                    string tests = cbl_SWtestcomponenten.SelectedItem.ToString();
                    string[] objects;
                    objects = tests.Split(',', ':');
                    int id = Convert.ToInt32(objects[1]);


                    //id meegeven en meegeven of het goedkeurd(true) of afgekeerd moet worden(false)
                    Filter.Approve(id, true);
                    cbl_SWtestcomponenten.Items.Clear();
                }
                catch (FilterException f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }

        /// <summary>
        /// afkeuren van een order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SWafkeuring_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            if (isChecked)
            {
                try
                {
                    string tests = cbl_SWtestcomponenten.SelectedItem.ToString();
                    string[] objects;
                    objects = tests.Split(',', ':');
                    int id = Convert.ToInt32(objects[1]);


                    //id meegeven en meegeven of het goedkeurd(true) of afgekeerd moet worden(false)
                    Filter.Approve(id, false);
                    cbl_SWtestcomponenten.Items.Clear();
                }
                catch (FilterException f)
                {
                    MessageBox.Show(f.Message);
                }
            }
        }
    }
}