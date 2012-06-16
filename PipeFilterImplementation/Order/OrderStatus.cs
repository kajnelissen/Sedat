using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public enum OrderStatus
    {
        Start,
        Assembled,
        HardwareTested,
        HardwareErrors,
        SoftwareInstalled,
        SoftwareTested,
        SoftwareErrors,
        End
    }
}
