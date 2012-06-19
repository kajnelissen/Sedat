using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simulation;

namespace ConsoleGUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductionSim sim = new ProductionSim();
            sim.Simulate();

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadKey();
        }
    }
}
