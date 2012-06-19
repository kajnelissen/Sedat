using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simulation;

namespace ConsoleGUI
{
    public class Program
    {
        /// <summary>
        /// Lelijk
        /// 
        /// Er dient een extra pipe te komen voor de testcases. Op dit moment geeft hij nog correcte 
        /// software en hardware terug.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            ProductionSim sim = new ProductionSim();
            sim.Simulate();

            Console.WriteLine("Console GUI guidelines:");
            Console.WriteLine("=======================");
            Console.WriteLine("Press ENTER to exit.");
            Console.WriteLine("Press A to view assembly filter input/output.");
            Console.WriteLine("Press S to view hwtest filter input/output.");
            Console.WriteLine("Press D to view swinstall filter input/output.");
            Console.WriteLine("Press F to view swtest filter input/output.");
            Console.WriteLine("\n*It may be the case you have to press a bit longer ;)*");
            Console.WriteLine("=======================\n\n");

            bool run = true;
            while (run)
            {
                ConsoleKey k = Console.ReadKey().Key;
                if (k == ConsoleKey.Enter)
                {
                    run = false;
                }
                else if (k == ConsoleKey.A)
                {
                    Console.WriteLine("\nHardware Assembly");
                    Console.WriteLine("Input:");
                    PrintStringList(sim.GetFilterInput("hwAssemble"));
                    Console.WriteLine("Output:");
                    PrintStringList(sim.GetFilterOutput("hwAssemble"));
                    Console.WriteLine();
                }
                else if (k == ConsoleKey.S)
                {
                    Console.WriteLine("\nHardware Testing");
                    Console.WriteLine("Input:");
                    PrintStringList(sim.GetFilterInput("hwTest"));
                    Console.WriteLine("Output:");
                    PrintStringList(sim.GetFilterOutput("hwTest"));
                    Console.WriteLine();
                }
                else if (k == ConsoleKey.D)
                {
                    Console.WriteLine("\nSoftware Installationy");
                    Console.WriteLine("Input:");
                    PrintStringList(sim.GetFilterInput("swInstall"));
                    Console.WriteLine("Output:");
                    PrintStringList(sim.GetFilterOutput("swInstall"));
                    Console.WriteLine();
                }
                else if (k == ConsoleKey.F)
                {
                    Console.WriteLine("\nSoftware Testing");
                    Console.WriteLine("Input:");
                    PrintStringList(sim.GetFilterInput("swTest"));
                    Console.WriteLine("Output:");
                    PrintStringList(sim.GetFilterOutput("swTest"));
                    Console.WriteLine();
                }
            }


            Console.ReadKey();
        }

        private static void PrintStringList(List<string> l)
        {
            foreach (string s in l)
            {
                Console.WriteLine("\t" + s);
            }
        }
    }
}
