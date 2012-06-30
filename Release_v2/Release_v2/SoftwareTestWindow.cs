using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Filters;

namespace Release_v2
{
    public partial class SoftwareTestWindow : BaseWindow
    {
        public SoftwareTestWindow(ref IFilter filter)
            : base(ref filter)
        {
            InitializeComponent();
        }

        public override void UpdateForm()
        {
            throw new NotImplementedException();
        }
    }
}
