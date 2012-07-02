using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order
{
    public class SoftwareFactory
    {
        /// <summary>
        /// Retourneert software
        /// </summary>
        /// <param name="type">Het soort software</param>
        /// <param name="version">Versie van software</param>
        /// <returns></returns>
        public static ISoftware CreateSoftware(string type, string version)
        {
            ISoftware s = null;
            switch (type)
            {
                case "os":
                    s = new OperatingSystem(version);
                    break;
                case "office":
                    s = new OfficeSuite(version);
                    break;
            }
            return s;
        }
    }
}
