using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Release_v2
{
    public partial class EntryWindow : Form
    {
        private bool _running;

        public EntryWindow()
        {
            InitializeComponent();
            this._running = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!this._running)
            {
                // hier moeten alle andere forms geopend worden

                this._running = true;
            }
        }
    }
}
