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
    public partial class SoftwareInstallWindow : BaseWindow
    {
        public SoftwareInstallWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
        }

        public override void UpdateForm()
        {
            lb_OrderToInstall.Items.Clear();

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                lb_OrderToInstall.Items.Add(kvp.Value.ToString());
            }
        }

        /// <summary>
        /// Installatie is voltooid geeft de gebruiker aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Bevestig_Installatie_Click(object sender, EventArgs e)
        {
            bool isChecked = true;
            for (int index = 0; index < cbl_ComponentenInstall.Items.Count; index++)
            {
                if (cbl_ComponentenInstall.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            if (isChecked)
            {
                DialogResult result = MessageBox.Show("Weet u zeker dat de installatie is voltooid?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    // Controleren of alle componenten aangevinkt zijn.
                    for (int index = 0; index < cbl_ComponentenInstall.Items.Count; index++)
                    {
                        if (cbl_ComponentenInstall.GetItemCheckState(index) == CheckState.Unchecked)
                        {
                            isChecked = false;
                        }
                    }

                    // Als alle componenenten aangevinkt zijn dan wordt de orderstatus gewijzigt.
                    if (isChecked)
                    {
                        try
                        {
                            string tests = cbl_ComponentenInstall.SelectedItem.ToString();
                            string[] objects;
                            objects = tests.Split(',', ':');
                            int id = Convert.ToInt32(objects[1]);

                            Filter.Process(id); // dit kan een exception geven... opvangen!
                            cbl_ComponentenInstall.Items.Clear();
                        }
                        catch (FilterException f)
                        {
                            MessageBox.Show(f.Message);
                        }
                        MessageBox.Show("Installatie is voltooid.");
                    }
                }
                else
                {
                    MessageBox.Show("Rond de installatie af.");
                }
            }
            else
            {
                MessageBox.Show("Niet alle componenten zijn aagevinkt.");
            }
        }

        /// <summary>
        /// Componenten van geselecteerde order worden weggeschrijven naar checklistbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_OrderToInstall_SelectedIndexChanged(object sender, EventArgs e)
        {
            string obj = lb_OrderToInstall.SelectedItem.ToString();
            string[] objects;
            objects = obj.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            foreach (KeyValuePair<int, AbstractOrder> kvp in Filter.Input)
            {
                if (Filter.Input[kvp.Key].OrderId == id)
                {
                    for (int index2 = 0; index2 < Filter.Input[id].Components.Count; index2++)
                    {
                        cbl_ComponentenInstall.Items.Add(Filter.Input[id].Components[index2]);
                    }
                }
            }
        }
    }
}