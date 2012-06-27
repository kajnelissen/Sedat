﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Filters;
using Pipes;

namespace PFFactory
{
    /// <summary>
    /// Interface voor het aanmaken van nieuwe pipes en filters.
    /// </summary>
    public interface IPipeFilterFactory
    {
        /// <summary>
        /// Creeërt niuewe filter.
        /// </summary>
        /// <param name="type">naam van de te creeëren filter</param>
        /// <returns>Gecreeërde filter</returns>
        IFilter CreateFilter(string type);

        /// <summary>
        /// Creeërt nieuwe pipe tussen twee filters.
        /// </summary>
        /// <returns></returns>
        IPipe CreatePipe();
    }
}
