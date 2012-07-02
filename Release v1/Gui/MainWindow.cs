using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Simulation;


namespace Gui
{
    public partial class MainWindow : Form 
    {
        //private System.Timers.Timer updateTimer;

        private ProductionSim sim;

        //private delegate void stringDelegate(string s);

        public MainWindow()
        {
            InitializeComponent();

            sim = new ProductionSim();
            sim.Simulate();
            sim.Notify += UpdateFilters;

            //updateTimer = new System.Timers.Timer(1000); // 1000 millisecondes tussen updates
            //updateTimer.Enabled = true;
           // updateTimer.Elapsed += new System.Timers.ElapsedEventHandler(Update); // Update verwijst naar je updatemethode            
        }


        private void WriteBufferToListbox(List<string> bufferContent, ListBox lb)
        {
            foreach (string s in bufferContent)
            {
                lb.Items.Add(s);              
            }
        }

        public void UpdateFilters()
        {
            // implementatie wat betreft vullen van listboxes etc

            lb_OrderHwBouwen.Items.Clear();
            lb_TestOrders.Items.Clear();
            lb_OrderToInstall.Items.Clear();
            lb_swTestOrders.Items.Clear();
            WriteBufferToListbox(sim.GetFilterInput("hwAssemble"), lb_OrderHwBouwen);
            WriteBufferToListbox(sim.GetFilterInput("hwTest"), lb_TestOrders);
            WriteBufferToListbox(sim.GetFilterInput("swInstall"), lb_OrderToInstall);
            WriteBufferToListbox(sim.GetFilterInput("swTest"), lb_swTestOrders);
        }

        /// <summary>
        /// De geselecteerde order wordt geplaatst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_orderPlaatsen_Click(object sender, EventArgs e)
        {
            string soort = cb_soort.SelectedItem.ToString().ToLower();
            string cpu = cb_cpu.SelectedItem.ToString(); 
            string gpu = cb_gpu.SelectedItem.ToString(); 
            string ssd = cb_ssd.SelectedItem.ToString();
            string overige = tb_overige.Text;
            string opmerkingen = tb_opmerkingen.Text;

            sim.NewOrder(soort, cpu, gpu, ssd, overige, opmerkingen);
            lb_bevestigOrder.Text = "Order is correct ingevoerd.";
        }

        /// <summary>
        /// Bij "binnenkomende orders" wordt een order geselecteerd. De order wordt dan 
        /// verplaatst naar "orders in behandeling." 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_accepteren1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// De geselecteerde order wordt afgehandeld en verstuurd naar beheer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_afhandelen1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// De geselecteerde order wordt verplaatst naar "hardware gaande tests"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_hwTesten_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Voordat de hardwaretest wordt afgehandeld, wordt er een testrapport geupload.
        /// Deze wordt bij afhandeling verstuurd naar beheer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_hwRapport_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// De geselecteerde test wordt afgehandeld en verstuurd naar beheer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_testAfhandelen1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Een order wordt geselecteerd uit "hardware geteste orders" en wordt verplaatst naar 
        /// "installatie orders in behandeling"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_accepteren2_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// De geselecteerde order wordt afgehandeled en verstuurd naar beheer voor goedkeuring.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_afhandelen2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// De geselecteerde order wordt verplaatst naar "software tests gaande"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_swTesten_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Voordat de softwaretestwordt afgehandeld, wordt er een testrapport geupload.
        /// Deze wordt bij afhandeling verstuurd naar beheer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_swRapport_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// De geselecteerde test wordt afgehandeld en verstuurd naar beheer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_testAfhandelen2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// De des betreffende order wordt goedgekeurd en verstuurd naar het volgende process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_goedkeuren_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// De des betreffende order wordt afgekeurd en verstuurd naar haar oorspronkelijke process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_afkeuren_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Het geselecteerde testrapport wordt geopend.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_testOpenen_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tests = lb_OrderHwBouwen.SelectedItem.ToString();
            string[] objects;
            objects = tests.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            List<string> components = sim.GetStringOrders("hwAssemble", id);
            cl_ComponentenInOrder.Items.Clear();

            for (int index = 0; index < components.Count; index++)
            {
                cl_ComponentenInOrder.Items.Add(components[index]);
            }
        }

        private void btn_assemblage_voltooid_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            for (int index = 0; index < cl_ComponentenInOrder.Items.Count; index++)
            {
                if(cl_ComponentenInOrder.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            if (isChecked)
            {
                string tests = lb_OrderHwBouwen.SelectedItem.ToString();
                string[] objects;
                objects = tests.Split(',', ':');
                int id = Convert.ToInt32(objects[1]);

                sim.setProcess("hwTest", id, false);
                cl_ComponentenInOrder.Items.Clear();
            }
        }

        private void lb_TestOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tests = lb_TestOrders.SelectedItem.ToString();
            string[] objects;
            objects = tests.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            List<string> components = sim.GetStringOrders("hwTest", id);
            cl_ComponentenInOrder.Items.Clear();

            for (int index = 0; index < components.Count; index++)
            {
                cl_hwTestComponenten.Items.Add(components[index]);
            }
        }

        private void btn_akkoord_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            for (int index = 0; index < cl_hwTestComponenten.Items.Count; index++)
            {
                if (cl_hwTestComponenten.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            if (isChecked)
            {
                //string tests =  checkedListBox1.SelectedItem.ToString();
                //string[] objects;
                //objects = tests.Split(',', ':');
                int id = 1;

                sim.setProcess("hwTest", id, isChecked);
                clear_fields_testHw();
            }
        }

        private void btn_afgekeurd_Click(object sender, EventArgs e)
        {
            sim.setProcess("hwTest", 1, false);
            clear_fields_testHw();
        }

        private void clear_fields_testHw()
        {
            cl_hwTestComponenten.Items.Clear();
        }

        private void lb_OrderToInstall_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tests = lb_OrderToInstall.SelectedItem.ToString();
            string[] objects;
            objects = tests.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            List<string> components = sim.GetStringOrders("swInstall", id);
            cl_ComponentenInOrder.Items.Clear();

            for (int index = 0; index < components.Count; index++)
            {
                cl_ComponentenInstall.Items.Add(components[index]);
            }
        }

        private void btn_Bevestig_Installatie_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            for (int index = 0; index < cl_ComponentenInstall.Items.Count; index++)
            {
                if (cl_ComponentenInstall.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            if (isChecked)
            {
                string tests = lb_OrderToInstall.SelectedItem.ToString();
                string[] objects;
                objects = tests.Split(',', ':');
                int id = Convert.ToInt32(objects[1]);

                sim.setProcess("swInstall", id, true);
                cl_ComponentenInstall.Items.Clear();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tests = lb_swTestOrders.SelectedItem.ToString();
            string[] objects;
            objects = tests.Split(',', ':');
            int id = Convert.ToInt32(objects[1]);

            List<string> components = sim.GetStringOrders("swTest", id);
            cl_testComponentenSw.Items.Clear();

            for (int index = 0; index < components.Count; index++)
            {
                cl_testComponentenSw.Items.Add(components[index]);
            }
        }

        private void btn_swGoed_Click(object sender, EventArgs e)
        {
            bool isChecked = true;

            for (int index = 0; index < cl_testComponentenSw.Items.Count; index++)
            {
                if (cl_testComponentenSw.GetItemCheckState(index) == CheckState.Unchecked)
                {
                    isChecked = false;
                }
            }

            if (isChecked)
            {
                sim.setProcess("swTest", 1, isChecked);
                cl_testComponentenSw.Items.Clear();
            }
        }

        private void btn_swAfgekeurd_Click(object sender, EventArgs e)
        {
            sim.setProcess("swTest", 1, false);
            cl_testComponentenSw.Items.Clear();
        }
    }
}

