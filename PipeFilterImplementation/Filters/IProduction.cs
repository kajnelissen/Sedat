using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filters
{
    /// <summary>
    /// Hoofdklasse van alle productie processen. In de productieprocessen worden de statussen gewijzigd.
    /// </summary>
    public abstract class IProduction : IFilter
    {
        /// <summary>
        /// Abstracte methode process waarin de status van een order gewijzigd wordt in een object.
        /// </summary>
        //public abstract void Process();
    }
}
