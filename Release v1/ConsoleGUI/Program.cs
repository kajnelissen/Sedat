using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simulation;

namespace ConsoleGUI
{
    public class Program
    {
        private static AutoSim sim;

        /// <summary>
        /// Lelijk
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            sim = new AutoSim();
            sim.Notify += PrintFilters;
            sim.Simulate();

            Console.WriteLine("Console GUI guidelines:");
            Console.WriteLine("=======================");
            Console.WriteLine("Press ENTER to exit.");
            Console.WriteLine("=======================\n\n");

            bool run = true;
            while (run)
            {
                ConsoleKey k = Console.ReadKey().Key;
                if (k == ConsoleKey.Enter)
                {
                    run = false;
                }
            }
            
            Console.ReadKey();
        }

        public static void PrintStringList(List<string> l)
        {
            foreach (string s in l)
            {
                Console.WriteLine("\t" + s);
            }
        }

        public static void PrintFilters()
        { 
            Console.WriteLine("\nHardware Assembly");
            PrintFilter("hwAssemble");
                   
            Console.WriteLine("\nHardware Testing");
            PrintFilter("hwTest");
                    
            Console.WriteLine("\nSoftware Installation");
            PrintFilter("swInstall");
                    
            Console.WriteLine("\nSoftware Testing");
            PrintFilter("swTest");
                    
            Console.WriteLine("\nStorage");
            PrintFilter("storage");

            Console.WriteLine();
            Console.WriteLine("\n\n=======================\n\n");
        }

        public static void PrintFilter(string filter)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Input:");
            PrintStringList(sim.GetFilterInput(filter));
            Console.WriteLine("Output:");
            PrintStringList(sim.GetFilterOutput(filter));
        }
    }
}
