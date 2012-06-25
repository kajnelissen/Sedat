using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class ComponentFactory
    {
        /// <summary>
        /// Retourneert nieuwe component
        /// </summary>
        /// <param name="device">Het soort component</param>
        /// <param name="type">Type van component</param>
        /// <returns></returns>
        public static IComponent CreateComponent(string device, string type)
        {
            IComponent c = null;
            switch (device)
            {
                case "cpu":
                    c = new CPU(type);
                    break;
                case "gpu":
                    c = new GPU(type);
                    break;
                case "ssd":
                    c = new SSD(type);
                    break;
            }
            return c;
        }
    }
}
