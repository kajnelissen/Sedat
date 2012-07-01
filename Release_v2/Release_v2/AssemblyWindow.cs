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
    public partial class AssemblyWindow : BaseWindow
    {
        public AssemblyWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
        }

        public override void UpdateForm()
        {
            lb_AssemblageOrders.Items.Clear();

            //for (int index = 0; index < Filter.Input.Count; index++)
            //{
            //    lb_AssemblageOrders.Items.Add(Filter.Input[index]).ToString();
            //}

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                lb_AssemblageOrders.Items.Add(kvp.ToString());
            }
        }

        /// <summary>
        /// Assemblage van order wordt als voltooid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bevestig_assemblage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat alles correct is?", "", MessageBoxButtons.YesNo);
            //
            // Test the results of the previous three dialogs. [6]
            //
            if (result == DialogResult.Yes)
            {
                bool isChecked = true;

                // Controleren of alle componenten aangevinkt zijn.
                for (int index = 0; index < cbl_AssemblageComponenten.Items.Count; index++)
                {
                    if (cbl_AssemblageComponenten.GetItemCheckState(index) == CheckState.Unchecked)
                    {
                        isChecked = false;
                    }
                }

                // Als alle componenenten aangevinkt zijn dan wordt de orderstatus gewijzigt.
                if (isChecked)
                {
                    try
                    {
                        string tests = lb_AssemblageOrders.SelectedItem.ToString();
                        string[] objects;
                        objects = tests.Split(',', ':');
                        int id = Convert.ToInt32(objects[2]);


                        Filter.Process(id); // dit kan een exception geven... opvangen!
                        cbl_AssemblageComponenten.Items.Clear();
                    }
                    catch (FilterException f)
                    {
                        MessageBox.Show(f.Message);
                    }
                    MessageBox.Show("Assemblage is voltooid.");
                }
            }
            else
            {
                MessageBox.Show("Rond de assemblage af.");
            }
        }
        
        /// <summary>
        /// Geselecteerde order in lb_AssemblageOrders wordt geladen en hiervan worden de componenten 
        /// naar de checklistbox cbl_AssemblageComponenenten geschreven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_AssemblageOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string obj = lb_AssemblageOrders.SelectedItem.ToString();
            string[] objects;
            objects = obj.Split(',', ':');
            int id = Convert.ToInt32(objects[2]);

            //for (int index = 0; index < Filter.Input.Count; index++)
            //{
            //    if (Filter.Input[index].OrderId == id)
            //    {
            //        for (int index2 = 0; index2 < Filter.Input[index].Components.Count; index2++)
            //        {
            //            cbl_AssemblageComponenten.Items.Add(Filter.Input[index].Components[index2]);
            //        }
            //    }
            //}

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                if (kvp.Key == id)
                {
                    for (int index2 = 0; index2 < Filter.Input[id].Components.Count; index2++)
                    {
                        cbl_AssemblageComponenten.Items.Add(Filter.Input[id].Components[index2]);
                    }
                }
            }
        }
    }
}
