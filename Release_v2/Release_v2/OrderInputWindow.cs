﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Order;

namespace Release_v2
{
    public partial class OrderInputWindow : Form
    {
        /// <summary>
        /// nieuwe order factory aanmaken
        /// </summary>
        private IOrderFactory orderFac;

        /// <summary>
        /// nieuw component cpu
        /// </summary>
        private CPU cpu;

        /// <summary>
        /// nieuw component gpu
        /// </summary>
        private GPU gpu;

        /// <summary>
        /// nieuw component ssd
        /// </summary>
        private SSD ssd;


        public OrderInputWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// nieuwe order creeëren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_orderPlaatsen_Click(object sender, EventArgs e)
        {
            cpu = new CPU(cb_cpu.SelectedItem.ToString());
            gpu = new GPU(cb_gpu.SelectedItem.ToString());
            ssd = new SSD(cb_ssd.SelectedItem.ToString());
            
            AbstractOrder order = orderFac.CreateOrder(cb_soort.SelectedItem.ToString());
            order.AddComponent(cpu);
            order.AddComponent(gpu);
            order.AddComponent(ssd);
        }
    }
}
