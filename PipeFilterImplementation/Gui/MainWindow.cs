using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gui
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// De geselecteerde order wordt geplaatst.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_orderPlaatsen_Click(object sender, EventArgs e)
        {

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

        
    }
}
