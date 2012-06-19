using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Pipes;

namespace PFFactory
{
    public class PipeFilterFactory : AbstractPipeFilterFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public PipeFilterFactory() : base()
        { 
            
        }

        /// <summary>
        /// Creeërt nieuwe filter
        /// </summary>
        /// <param name="type">string met naam van de filter</param>
        /// <returns></returns>
        public override IFilter CreateFilter(string type)
        {
            if (type.ToUpper() == "HWASSEMBLE")
            {
                return new HWAssemble();
            }
            else if (type.ToUpper() == "HWTEST")
            {
                return new HWTest();
            }
            else if (type.ToUpper() == "SWINSTALL")
            {
                return new SWInstall();
            }
            else if (type.ToUpper() == "SWTEST")
            {
                return new SWTest();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Creeërt nieuwe pipe.
        /// </summary>
        /// <returns>Pipe</returns>
        public override IPipe CreatePipe()
        {
            return new Pipe();
        }
    }
}
