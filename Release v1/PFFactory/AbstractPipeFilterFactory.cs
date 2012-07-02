using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Pipes;

namespace PFFactory
{
    /// <summary>
    /// Abstractie klasse voor het aanmaken van nieuwe pipes en filters.
    /// </summary>
    public abstract class AbstractPipeFilterFactory : IPipeFilterFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public AbstractPipeFilterFactory()
        { 
            
        }

        /// <summary>
        /// Creeërt nieuwe filter.
        /// </summary>
        /// <param name="type">naam van de te creeëren filter</param>
        /// <returns>Gecreeërde filter</returns>
        public abstract IFilter CreateFilter(string type);

        /// <summary>
        /// Creeërt nieuwe pipe tussen twee filters.
        /// </summary>
        /// <returns></returns>
        public abstract IPipe CreatePipe();
    }
}
