using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simulation;

namespace ConsoleGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductionSim sim = new ProductionSim();
            sim.Simulate();
        }
    }
}
